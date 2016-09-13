using Financiera.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancieraInfraestructura.Datos
{
    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
       FinancieraContexto io_contexto;

        public IDbSet<T> Entidad { get; set; }

        public RepositorioGenerico(FinancieraContexto ao_contexto)
        {
            this.io_contexto = ao_contexto;
            this.Entidad = ao_contexto.Set<T>();
        }
        public RepositorioGenerico() : this(new FinancieraContexto())
        {
            //this.Entidad = System.Reflection.Assembly.GetAssembly(typeof(c)).Create
        }

        public T ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }

        public IList<T> ObtenerPorExpresion(System.Linq.Expressions.Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null,
            byte aby_limits = 0)

        {
            if (ao_llaves == null)
                return Entidad.ToList();
            else
                return Entidad.Where(ao_llaves).ToList();
        }

        public IQueryable<T> Listar()
        {
            return Entidad;
        }

        public bool Adicionar (T ao_entidad)
        {
            Entidad.Add(ao_entidad);
            return true;
        }

        public bool Actualizar (T ao_entidad)
        {
            throw new NotImplementedException();
        }

        public bool GuardarCambios()
        {
            io_contexto.SaveChanges();
            return true;
        }


    }
}
