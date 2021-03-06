﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financiera.Dominio
{
    public class CuentaCorriente
    {
        #region Propiedades

        public int NumeroCuenta   { get;  set;}

        public int Saldo   { get  ;  set;}

        public int FechaApertura       {      get;  set;          }
        /// <summary>
        /// Estado de la cuenta del cliente
        /// </summary>
        public int EstadoCuenta        {            get;            set;        }

        public string CodigoCuenta { get; set; }

        public int CodigoCliente { get; set; }

        public int Saldocuenta { get; set; }

        public virtual Cliente Propietario        {            get;            set;            }

        public void Aperturar()
        {
            throw new System.NotImplementedException();
        }

        public void Cancelar()
        {
            throw new System.NotImplementedException();
        }

        public void Bloquear()
        {
            throw new System.NotImplementedException();
        }

        public void Desbloquear()
        {
            throw new System.NotImplementedException();
        }

    }
}