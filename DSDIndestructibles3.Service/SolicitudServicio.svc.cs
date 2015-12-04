using DSDIndestructibles3.Datos;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
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
            int id = 0;
            try
            {
                id = SolicitudServicioDAO.Add(oSolicitudServicioBE);
            }
            catch (Exception)
            {
                string rutacola = @".\private$\SolicitudServicioRecibida";
                if (!MessageQueue.Exists(rutacola))
                    MessageQueue.Create(rutacola);

                MessageQueue cola = new MessageQueue(rutacola);
                Message mensaje = new Message();
                mensaje.Label = "Nueva Solicitud de Servicio";
                mensaje.Body = oSolicitudServicioBE;
                cola.Send(mensaje);
                oSolicitudServicioBE.SolicitudServicioId = -1;
                return oSolicitudServicioBE;
            }
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
                MyCustomErrorDetail customError = new MyCustomErrorDetail();
                customError.ErrorDetails = "SolicitudServicio no existe";
                customError.ErrorInfo = "No existe SolicitudServicio con id.";
                
                throw new WebFaultException<MyCustomErrorDetail>(customError, HttpStatusCode.NotFound);
            }
            return sol;
        }

        public SolicitudServicioDTO ObtenerPorCampos(int idMotivo, int idComercio, int idModelo)
        {
            SolicitudServicioDTO sol = SolicitudServicioDAO.GetByFields(idMotivo, idComercio, idModelo);
            if (sol != null)
            {
                MyCustomErrorDetail customError = new MyCustomErrorDetail();
                customError.ErrorDetails = "SolicitudServicio existe";
                customError.ErrorInfo = "SolicitudServicio existe. Para una nuevo registro, los campo motivo, comercio and modelo no deben estar registrado.";
                throw new WebFaultException<MyCustomErrorDetail>(customError, HttpStatusCode.Found);
            }
            return sol;
        }


    }
}
