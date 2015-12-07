using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace DSDIndestructibles3.Web.forms.procesos
{
    public partial class RegistrarSolicitud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            txtFecSol.Text = DateTime.Today.ToShortDateString();
            var oMotivoSolicitudServiceClient = new Services.MotivoSolicitud.MotivoSolicitudServiceClient();
            var oMotSol = new Services.MotivoSolicitud.MotivoSolicitudDTO();

            var lMotivoSolicitud = oMotivoSolicitudServiceClient.GetAll();
            var oMotivo = new DSDIndestructibles3.Web.Services.MotivoSolicitud.MotivoSolicitudDTO();
            oMotivo.MotivoSolicitudId = 0;
            oMotivo.Descripcion = "-- SELECCIONAR --";
            lMotivoSolicitud.Insert(0, oMotivo);
            ddlMotSol.DataSource = lMotivoSolicitud;
            ddlMotSol.DataTextField = "Descripcion";
            ddlMotSol.DataValueField = "MotivoSolicitudId";
            ddlMotSol.DataBind();

            var oClienteServiceClient = new Services.Cliente.ClienteServiceClient();
            var lCliente = oClienteServiceClient.GetAll();
            var oCliente = new DSDIndestructibles3.Web.Services.Cliente.ClienteDTO();
            oCliente.ClienteId = 0;
            oCliente.Descripcion = "-- SELECCIONAR --";
            lCliente.Insert(0, oCliente);
            ddlCli.DataSource = lCliente;
            ddlCli.DataTextField = "Descripcion";
            ddlCli.DataValueField = "ClienteId";
            ddlCli.DataBind();

            var oTerminalServiceClient = new Services.Terminal.TerminalServiceClient();
            var lTerminal = oTerminalServiceClient.GetAll();
            var oTerminal = new DSDIndestructibles3.Web.Services.Terminal.TerminalDTO();
            oTerminal.TerminalId = 0;
            oTerminal.Descripcion = "-- SELECCIONAR --";
            lTerminal.Insert(0, oTerminal);
            ddlTerSol.DataSource = lTerminal;
            ddlTerSol.DataTextField = "Descripcion";
            ddlTerSol.DataValueField = "TerminalId";
            ddlTerSol.DataBind();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                string postdata =
                    "{\"ComercioId\":\"" + ddlCli.SelectedValue + "\",\"MotivoSolicitudId\":\"" + ddlMotSol.SelectedValue +
                    "\",\"TerminalSolicitadoId\":\"" + ddlTerSol.SelectedValue + "\",\"Estado\":\"" + ddlEstado.SelectedValue +
                    "\",\"UsrReg\":\"" + MySession.UserId.ToString() + "\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:29231/SolicitudServicio.svc/SolicitudServicio");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string alumnoJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                SolicitudServicioDTO solicitud = js.Deserialize<SolicitudServicioDTO>(alumnoJson);

                Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('Orden Servicio registrado.');</script>");
            }
        }

        private bool Validar()
        {
            try
            {
                // http://localhost:29231/SolicitudServicio.svc/SolicitudServicio/Buscar/?idMotivo=1&idComercio=1&idModelo=1
                HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create(
                    "http://localhost:29231/SolicitudServicio.svc/ObtenerPorCampos?idMotivo=" + ddlMotSol.SelectedValue + "&idComercio=" + ddlCli.SelectedValue + "&idModelo=" + ddlTerSol.SelectedValue);
                req2.Method = "GET";
                HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
                StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                string solicitudJson2 = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                SolicitudServicioDTO solicitudObtenido = js.Deserialize<SolicitudServicioDTO>(solicitudJson2);
            }
            catch (WebException e)
            {
                HttpStatusCode code = ((HttpWebResponse)e.Response).StatusCode;
                string message = ((HttpWebResponse)e.Response).StatusDescription;
                StreamReader reader = new StreamReader(e.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                MyCustomErrorDetail Observacion = js.Deserialize<MyCustomErrorDetail>(error);
                string sError = "";
                sError = Observacion.ErrorDetails;

                Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('" + sError + "');</script>");
            }

            return false;
        }
    }
}