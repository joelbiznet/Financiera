using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Financiera.Dominio
{/// <summary>
 /// CLIENTEEEEEEEEE V6
 /// </summary>


    public class Cliente
    {
        /// <summary>
        /// Propiedades de la Clase Cliente
        /// </summary>
        public int CodigoCliente { get;set; }

        public String NombreCliente { get; set; }

        public Byte TipoCliente{ get; set; }

        /// <summary>
        /// Metodo que devuelve los datos del cliente y su cuenta
        /// </summary>
        /// <param name="as_nombre"></param>
        /// <param name="aby_tipo"></param>
        /// <returns>Datos del Cliente y Cuenta</returns>

        public Cliente DarAlta (String as_nombre, byte aby_tipo)
        {
            return new Cliente()
            {
                NombreCliente = as_nombre,
                TipoCliente = aby_tipo
            };
        }

        /// <summary>
        /// Metodo que realiza el Alta para el Cliente
        /// </summary>
        public void DarAlta()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Metodo para modificar el nombre del cliente
        /// </summary>

        public void ModificarNombre()
        {
            throw new System.NotImplementedException();
        }
    }
}