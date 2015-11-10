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
            Services.SolicitudServicio.SolicitudServicioClient oClient = new Services.SolicitudServicio.SolicitudServicioClient();
            Services.SolicitudServicio.SolicitudServicioDTO oSol = new Services.SolicitudServicio.SolicitudServicioDTO();

            Services.Cliente.ClienteServiceClient oClienteServiceClient = new Services.Cliente.ClienteServiceClient();
            Services.Cliente.ClienteDTO oCliente= new Services.Cliente.ClienteDTO();

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Services.SolicitudServicio.SolicitudServicioClient oClient = new Services.SolicitudServicio.SolicitudServicioClient();
                Services.SolicitudServicio.SolicitudServicioDTO oSol = new Services.SolicitudServicio.SolicitudServicioDTO();
                oSol.ComercioId = int.Parse(ddlCom.SelectedValue);
                oSol.MotivoSolicitudId = int.Parse(ddlMotSol.SelectedValue);
                oSol.TerminalSolicitadoId = int.Parse(ddlTerSol.SelectedValue);
                oSol.Estado = ddlEstado.SelectedValue;
                oSol.UsrReg = MySession.UserId;
                oClient.Registrar(oSol);

                ClientScriptManager cs = Page.ClientScript;
                cs.RegisterClientScriptBlock(this.GetType(), "Msj", "Solicitud registrada correctamente.");
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }
    }
}