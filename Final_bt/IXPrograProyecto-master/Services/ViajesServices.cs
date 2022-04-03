using Dapper;
using DapperExtensions;
using ProyectoFinal1.DML;
using ProyectoFinal1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Services
{
    public class ViajesServices
    {
        private SqlConnection _Conn = new();
        //Instalar Dapper y SQL
        private static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=localhost\SOPHIA;Initial Catalog=hoovers_db; Integrated Security=True; Pooling=False");
        }
        public tbl_clientes GetClientById(int id)
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select
            var vehiculos = _Conn.Query<tbl_clientes>("SELECT *  FROM  tbl_clientes").Where(f => f.id == id).ToList();
            return vehiculos.Count != 0 ? vehiculos.First() : null;

        }

        public IEnumerable<tbl_clientes> GetClients()
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select
            var cliente = _Conn.Query<tbl_clientes>("SELECT *  FROM  tbl_clientes").ToList();
            return cliente;
        }

        public void AddClient(tbl_clientes cliente)
        {
            try
            {
                _Conn = GetSqlConnection();
                _Conn.Open();
                var strInsert = DMLGenerator.CreateInsertStatement(cliente);
                var clientes = _Conn.Execute(strInsert, cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateClient(tbl_clientes cliente, int id, bool UseDapper = true)
        {
            try
            {
                _Conn = GetSqlConnection();
                _Conn.Open();
                var strInsert = DMLGenerator.UpdateInsertStatement(cliente);
                var clientes = _Conn.Execute(strInsert, cliente);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}