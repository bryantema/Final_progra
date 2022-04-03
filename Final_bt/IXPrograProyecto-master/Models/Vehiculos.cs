using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Models
{
    public class Vehiculos
    {
        public int id_vehiculo { get; set; }
        public string marca { get; set; }
        public string linea { get; set; }
        public int modelo { get; set; }
        public string placa { get; set; }
        public string color { get; set; }
        public int capacidad { get; set; }
        public int id_tipo { get; set; }
        public string stado { get; set; }
    }
}
