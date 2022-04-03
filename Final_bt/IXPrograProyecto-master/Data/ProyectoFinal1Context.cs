using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal1.Models;

namespace ProyectoFinal1.Data
{
    public class ProyectoFinal1Context : DbContext
    {
        public ProyectoFinal1Context (DbContextOptions<ProyectoFinal1Context> options)
            : base(options)
        {
        }

        public DbSet<ProyectoFinal1.Models.tbl_detalle_viaje> tbl_detalle_viaje { get; set; }

        public DbSet<ProyectoFinal1.Models.tbl_clientes> tbl_clientes { get; set; }

        public DbSet<ProyectoFinal1.Models.tbl_log> tbl_bitacora { get; set; }
    }
}
