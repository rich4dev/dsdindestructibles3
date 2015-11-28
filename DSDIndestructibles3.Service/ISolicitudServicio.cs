using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DSDIndestructibles3.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISolicitudServicio" in both code and config file together.
    [ServiceContract]
    public interface ISolicitudServicio
    {
        [OperationContract]
        [WebInvoke(Method="POST", UriTemplate="SolicitudServicio", ResponseFormat=WebMessageFormat.Json)]
        SolicitudServicioDTO Registrar(SolicitudServicioDTO oSolicitudServicioBE);
        [OperationContract]
        void Actualizar(SolicitudServicioDTO oSolicitudServicioBE);
        [OperationContract]
        //[WebInvoke(Method = "DELETE", UriTemplate = "SolicitudServicio/Delete/{id}", ResponseFormat = WebMessageFormat.Json)]
        void Eliminar(int id);
        [OperationContract]
        [WebInvoke(Method = "GET", BodyStyle = WebMessageBodyStyle.Wrapped, ResponseFormat = WebMessageFormat.Json)]
        SolicitudServicioDTO Obtener(int id); // UriTemplate = "SolicitudServicio/Obtener/?id={id}", 
        //[OperationContract]
        //List<SolicitudServicioDTO> ListarBandeja(string fechaDesde, string fechaHasta, string estado, int empresaId);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json)]
        SolicitudServicioDTO ObtenerPorCampos(int idMotivo, int idComercio, int idModelo); // , UriTemplate = "SolicitudServicio/Buscar/?idMotivo={idMotivo}&idComercio={idComercio}&idModelo={idModelo}"
    }
}
