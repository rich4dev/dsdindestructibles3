using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            var oCliente= new Services.Cliente.ClienteDTO();

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
            try
            {
                Services.SolicitudServicio.SolicitudServicioClient oClient = new Services.SolicitudServicio.SolicitudServicioClient();
                Services.SolicitudServicio.SolicitudServicioDTO oSol = new Services.SolicitudServicio.SolicitudServicioDTO();
                oSol.ComercioId = int.Parse(ddlCli.SelectedValue);
                oSol.MotivoSolicitudId = int.Parse(ddlMotSol.SelectedValue);
                oSol.TerminalSolicitadoId = int.Parse(ddlTerSol.SelectedValue);
                oSol.Estado = ddlEstado.SelectedValue;
                oSol.UsrReg = MySession.UserId;
                oSol.FechaReg = DateTime.Today;
                oClient.Registrar(oSol);

                Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessage", "<script language='javascript'>alert('Solicitud registrada correctamente');</script>");
            }
            catch (Exception)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('Ocurrio un error.');</script>");
            }          
        }
    }
}