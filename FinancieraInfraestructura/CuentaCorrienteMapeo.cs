using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancieraInfraestructura
{
    class CuentaCorrienteMapeo : EntityTypeConfiguration <CuentaCorriente>
    {
        public CuentaCorrienteMapeo()
        {
            ToTable("CUENTAS_CORRIENTES", "CC");
            HasKey(K => K.NumeroCuenta);
            Property(p => p.NumeroCuenta).HasColumnName("NUM_CUENTA").IsRequired();
            Property(p => p.CodigoCuenta).HasColumnName("COD_CUENTA").IsRequired();
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            Property(p => p.FechaApertura).HasColumnName("FEC_APERTURA").IsRequired();
            Property(p => p.Saldocuenta).HasColumnName("SAL_CUENTA").IsRequired();
            Property(p => p.EstadoCuenta).HasColumnName("IND_CUENTA").IsRequired();

            HasMany(m=> m.Propietario).WithMany().HasForeignKey(f=>f.CodigoCliente)
        }
    }
}
