using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financiera.Dominio
{/// <summary>
/// CLIENTEEEEEEEEE V3
/// </summary>
    public class Cliente
    {
        public int CodigoCliente { get;set; }

        public String NombreCliente { get; set; }

        public Byte TipoCliente{ get; set; }

        public Cliente DarAlta (String as_nombre, byte aby_tipo)
        {
            return new Cliente()
            {
                NombreCliente = as_nombre,
                TipoCliente = aby_tipo
            };
        }

        public void DarAlta()
        {
            throw new System.NotImplementedException();
        }

        public void ModificarNombre()
        {
            throw new System.NotImplementedException();
        }
    }
}