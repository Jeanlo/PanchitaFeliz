using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PruebaModelo
{
    public partial class Entities : DbContext
    {
        public virtual DbSet<CLIENTES_RESTAURANTE> CLIENTES_RESTAURANTE { get; set; }
        public virtual DbSet<EMPLEADOS> EMPLEADOS { get; set; }
        public virtual DbSet<PLATOS> PLATOS { get; set; }
        public virtual DbSet<INGREDIENTES> INGREDIENTES { get; set; }
        public virtual DbSet<ACOMPANANTES> ACOMPANANTES { get; set; }
    }
}
