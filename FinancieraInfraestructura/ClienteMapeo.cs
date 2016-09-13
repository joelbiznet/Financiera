using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancieraInfraestructura.Datos
{
    class ClienteMapeo : EntityTypeConfiguration<Financiera.Dominio.Cliente>
    {
        public ClienteMapeo() {
                ToTable("CLIENTES","CC");
                HasKey(K => K.CodigoCliente);
            Property(p => p.CodigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
        
        }
    }
}
