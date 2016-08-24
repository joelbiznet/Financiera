using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FinancieraInfraestructura
{
    class FinancieraContexto  : DbContext
    {
        #region Constructor

        public FinancieraContexto() : base("Conexion")
        {
            Database.SetInitializer<FinancieraContexto>(null);
        }
        #endregion

        #region propiedades
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<CuentaCorriente> CuentasCorrientes { get; set; }
        #endregion

        #region metodos
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder)
            modelBuilder.Configuration.Add(new ClienteMapeo());
            modelBuilder.Configurations.Add(new CuentaCorrienteMapeo());

        }
        #endregion
    }
}
