using DSDIndestructibles3.Datos;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DSDIndestructibles3.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SolicitudAfiliacion" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SolicitudAfiliacion.svc or SolicitudAfiliacion.svc.cs at the Solution Explorer and start debugging.
    public class SolicitudAfiliacion : ISolicitudAfiliacion
    {
        private Solicitud_AfiliacionData solicitudAfiliacionDAO = null;
        private Solicitud_AfiliacionData SolicitudServicioDAO
        {
            get
            {
                if (solicitudAfiliacionDAO == null)
                    solicitudAfiliacionDAO = new Solicitud_AfiliacionData();
                return solicitudAfiliacionDAO;
            }
        }

        public Solicitud_AfiliacionDTO GetSolicitudAfiliacionById(int id)
        {
            return SolicitudServicioDAO.Get(id);
        }
        public List<Solicitud_AfiliacionDTO> GetAllSolicitudAfiliaciones()
        {
            return SolicitudServicioDAO.GetAllSolicitudAfiliaciones();
        }
    }
}
