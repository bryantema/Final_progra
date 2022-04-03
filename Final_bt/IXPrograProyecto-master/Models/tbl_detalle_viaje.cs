using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Models
{
    public class tbl_detalle_viaje
    {
        public int id { get; set; }
        public DateTime fecha_salida { get; set; }
        public DateTime fecha_retorno { get; set; }
        public string destino { get; set; }
        public string estado { get; set; }
        public double costo { get; set; }
        public int id_cliente { get; set; }
        public int id_vehiculo { get; set; }
    }
}
