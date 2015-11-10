using DSDIndestructibles3.Data;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSDIndestructibles3.Service
{
    public class SolicitudServicio : ISolicitudServicio
    {

        private SolicitudServicioDAO solicitudServicioDAO = null;
        private SolicitudServicioDAO SolicitudServicioDAO
        {
            get
            {
                if (solicitudServicioDAO == null)
                    solicitudServicioDAO = new SolicitudServicioDAO();
                return solicitudServicioDAO;
            }
        }
        public void Registrar(Entities.SolicitudServicioBE oSolicitudServicioBE)
        {
            SolicitudServicioDAO.Crear(oSolicitudServicioBE);
        }

        public void Actualizar(Entities.SolicitudServicioBE oSolicitudServicioBE)
        {
            SolicitudServicioDAO.Modificar(oSolicitudServicioBE);
        }

        public void Eliminar(int id)
        {
            SolicitudServicioBE oSolicitudServicioBE = SolicitudServicioDAO.Obtener(id);
            SolicitudServicioDAO.Eliminar(oSolicitudServicioBE);
        }

        public List<Entities.SolicitudServicioBE> ListarBandeja(DateTime fechaDesde, DateTime fechaHasta, string estado, int empresaId)
        {
            return (List<Entities.SolicitudServicioBE>)SolicitudServicioDAO.ListarBandeja(fechaDesde, fechaHasta, estado, empresaId);
        }

        public Entities.SolicitudServicioBE Obtener(int id)
        {
            return SolicitudServicioDAO.Obtener(id);
        }

    }
}
