using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinal1.Models
{
    public class tbl_bitacora
    {
        public int? id { get; set; }
        public int? id_modulo { get; set; }
        public int? id_peticion { get; set; }
        public int? id_tipo { get; set; }
        public int? id_marca { get; set; }
        public DateTime? fecha_bitacora { get; set; }
        public string detalle { get; set; }
    }
}
