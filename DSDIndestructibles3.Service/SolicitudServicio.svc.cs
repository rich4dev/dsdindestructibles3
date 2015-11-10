using DSDIndestructibles3.Datos;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSDIndestructibles3.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SolicitudServicio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SolicitudServicio.svc or SolicitudServicio.svc.cs at the Solution Explorer and start debugging.
    public class SolicitudServicio : ISolicitudServicio
    {

        private SolicitudServicioData solicitudServicioDAO = null;
        private SolicitudServicioData SolicitudServicioDAO
        {
            get
            {
                if (solicitudServicioDAO == null)
                    solicitudServicioDAO = new SolicitudServicioData();
                return solicitudServicioDAO;
            }
        }
        public void Registrar(Entities.SolicitudServicioBE oSolicitudServicioBE)
        {
            SolicitudServicioDAO.Add(oSolicitudServicioBE);
        }

        public void Actualizar(Entities.SolicitudServicioBE oSolicitudServicioBE)
        {
            //SolicitudServicioDAO.Modificar(oSolicitudServicioBE);
        }

        public void Eliminar(int id)
        {
            //SolicitudServicioBE oSolicitudServicioBE = SolicitudServicioDAO.Obtener(id);
            //SolicitudServicioDAO.Eliminar(oSolicitudServicioBE);
        }

        public List<Entities.SolicitudServicioBE> ListarBandeja(DateTime fechaDesde, DateTime fechaHasta, string estado, int empresaId)
        {
            return null; //(List<Entities.SolicitudServicioBE>)SolicitudServicioDAO.ListarBandeja(fechaDesde, fechaHasta, estado, empresaId);
        }

        public Entities.SolicitudServicioBE Obtener(int id)
        {
            return null; // SolicitudServicioDAO.Obtener(id);
        }

    }
}
