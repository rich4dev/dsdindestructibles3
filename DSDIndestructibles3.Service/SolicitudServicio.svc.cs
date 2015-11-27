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
        public SolicitudServicioDTO Registrar(Entities.SolicitudServicioDTO oSolicitudServicioBE)
        {
            int id = SolicitudServicioDAO.Add(oSolicitudServicioBE);

            var obj = solicitudServicioDAO.Get(id);
            return obj;
        }

        public void Actualizar(Entities.SolicitudServicioDTO oSolicitudServicioBE)
        {
            SolicitudServicioDAO.Update(oSolicitudServicioBE);
        }

        public void Eliminar(int id)
        {
            SolicitudServicioDAO.Delete(id);
        }

        //public List<Entities.SolicitudServicioDTO> ListarBandeja(string fechaDesde, string fechaHasta, string estado, int empresaId)
        //{
        //    return SolicitudServicioDAO.GetBandeja( fechaDesde,   fechaHasta,   estado,   empresaId);
        //}

        public Entities.SolicitudServicioDTO Obtener(int id)
        {
            SolicitudServicioDTO sol = SolicitudServicioDAO.Get(id);
            if (sol == null)
            {
                MyCustomErrorDetail customError = new MyCustomErrorDetail("SolicitudServicio no existe",
                "No existe SolicitudServicio con id.");
                throw new WebFaultException<MyCustomErrorDetail>(customError, HttpStatusCode.NotFound);
            }
            return sol;
        }

        public SolicitudServicioDTO ObtenerPorCampos(int idMotivo, int idComercio, int idModelo)
        {
            SolicitudServicioDTO sol = SolicitudServicioDAO.GetByFields(idMotivo, idComercio, idModelo);
            if (sol != null)
            {
                MyCustomErrorDetail customError = new MyCustomErrorDetail("SolicitudServicio existe",
                "SolicitudServicio existe. Para una nuevo registro, los campo motivo, comercio and modelo no deben estar registrado.");
                throw new WebFaultException<MyCustomErrorDetail>(customError, HttpStatusCode.Found);
            }
            return sol;
        }


    }
}
