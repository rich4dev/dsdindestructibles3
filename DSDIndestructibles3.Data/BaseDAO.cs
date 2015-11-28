using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;

namespace DSDIndestructibles3.Data
{
    public class BaseDAO<Entidad, Id>
    {
        public Entidad Crear(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Save(entidad);
                sesion.Flush();
            }
            return entidad;
        }
        public Entidad Obtener(Id id)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                return sesion.Get<Entidad>(id);
            }
        }
        public Entidad Modificar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Update(entidad);
                sesion.Flush();
            }
            return entidad;
        }
        public void Eliminar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Delete(entidad);
                sesion.Flush();
            }
        }
        public ICollection<Entidad> ListarTodos()
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria busqueda = sesion.CreateCriteria(typeof(Entidad));
                return busqueda.List<Entidad>();
            }
        }
        public ICollection<Entidad> ListarBandeja(DateTime fechaDesde, DateTime fechaHasta, string estado, int empresaId)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                IQuery q = sesion.CreateQuery("from SolicitudServicio as s where s.[FechaReg] between :desde and :hasta and s.EmpresaId = :empresaId and s.estado = :estado");
                q.SetParameter("fechaDesde", fechaDesde);
                q.SetParameter("fechaHasta", fechaHasta);
                q.SetParameter("estado", estado);
                q.SetParameter("empresaId", empresaId);

                return q.List<Entidad>();
            }
        }
    }
}
