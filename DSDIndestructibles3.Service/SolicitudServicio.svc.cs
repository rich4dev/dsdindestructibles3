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
        public void Registrar(Entities.SolicitudServicioDTO oSolicitudServicioBE)
        {
            SolicitudServicioDAO.Add(oSolicitudServicioBE);
        }

        public void Actualizar(Entities.SolicitudServicioDTO oSolicitudServicioBE)
        {
            SolicitudServicioDAO.Update(oSolicitudServicioBE);
        }

        public void Eliminar(int id)
        {
            //SolicitudServicioBE oSolicitudServicioBE = SolicitudServicioDAO.Obtener(id);
            SolicitudServicioDAO.Delete(id);
        }

        public List<Entities.SolicitudServicioDTO> ListarBandeja(DateTime fechaDesde, DateTime fechaHasta, string estado, int empresaId)
        {
            return SolicitudServicioDAO.GetBandeja( fechaDesde,   fechaHasta,   estado,   empresaId);
        }

        public Entities.SolicitudServicioDTO Obtener(int id)
        {
            return SolicitudServicioDAO.Get(id);
        }

    }
}
