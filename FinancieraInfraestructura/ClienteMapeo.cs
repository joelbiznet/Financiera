using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancieraInfraestructura
{
    class ClienteMapeo : EntityTypeConfiguration<Financiera.Dominio.Cliente>
    {
        public ClienteMapeo() {
                ToTable=("CLIENTES","CC");
                HasKey(K => K.CodigoCliente);
            Property(p => p.Codigocliente).HasColumnName("COD_CLIENTE").IsRequired();
        
        }
    }
}
