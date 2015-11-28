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

            ddlMotSol.DataSource = oMotivoSolicitudServiceClient.GetAll();
            ddlMotSol.DataTextField = "Descripcion";
            ddlMotSol.DataValueField = "MotivoSolicitudId";
            ddlMotSol.DataBind();

            var oClienteServiceClient = new Services.Cliente.ClienteServiceClient();
            var oCliente = new Services.Cliente.ClienteDTO();

            ddlCli.DataSource = oClienteServiceClient.GetAll();
            ddlCli.DataTextField = "Descripcion";
            ddlCli.DataValueField = "ClienteId";
            ddlCli.DataBind();

            var oTerminalServiceClient = new Services.Terminal.TerminalServiceClient();
            var oTerminal = new Services.Terminal.TerminalDTO();

            ddlTerSol.DataSource = oTerminalServiceClient.GetAll();
            ddlTerSol.DataTextField = "Descripcion";
            ddlTerSol.DataValueField = "TerminalId";
            ddlTerSol.DataBind();
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Services.SolicitudServicio.SolicitudServicioClient oClient = new Services.SolicitudServicio.SolicitudServicioClient();
            //    Services.SolicitudServicio.SolicitudServicioDTO oSol = new Services.SolicitudServicio.SolicitudServicioDTO();
            //    oSol.ComercioId = int.Parse(ddlCli.SelectedValue);
            //    oSol.MotivoSolicitudId = int.Parse(ddlMotSol.SelectedValue);
            //    oSol.TerminalSolicitadoId = int.Parse(ddlTerSol.SelectedValue);
            //    oSol.Estado = ddlEstado.SelectedValue;
            //    oSol.UsrReg = MySession.UserId;
            //    oSol.FechaReg = DateTime.Today;
            //    oClient.Registrar(oSol);

            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessage", "<script language='javascript'>alert('Solicitud registrada correctamente');</script>");
            //}
            //catch (Exception)
            //{
            //    Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('Ocurrio un error.');</script>");
            //}          

            if (Validar())
            {

            }

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
        }

        private bool Validar()
        {
            try
            {
                // http://localhost:29231/SolicitudServicio.svc/SolicitudServicio/Buscar/?idMotivo=1&idComercio=1&idModelo=1
                HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create(
                    "http://localhost:29231/SolicitudServicio.svc/SolicitudServicio/Buscar?idMotivo=" + ddlMotSol.SelectedValue + "&idComercio=" + ddlCli.SelectedValue + "&idModelo=" + ddlTerSol.SelectedValue);
                req2.Method = "GET";
                HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
                StreamReader reader2 = new StreamReader(res2.GetResponseStream());
                string solicitudJson2 = reader2.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                SolicitudServicioDTO solicitudObtenido = js.Deserialize<SolicitudServicioDTO>(solicitudJson2);
            }
            catch (FaultException<MyCustomErrorDetail> we)
            {
                
            }
            catch (Exception exc)
            {
                                
            }
            return false;
        }
    }
}