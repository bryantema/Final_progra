using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Models
{
    public class tbl_clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string estado { get; set; }

    }
}
