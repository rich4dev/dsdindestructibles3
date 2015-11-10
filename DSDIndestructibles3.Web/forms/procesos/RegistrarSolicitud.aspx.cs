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
            SolicitudServicioServices.SolicitudServicioClient oClient = new SolicitudServicioServices.SolicitudServicioClient();
            SolicitudServicioServices.SolicitudServicioDTO oSol = new SolicitudServicioServices.SolicitudServicioDTO();

        
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitudServicioServices.SolicitudServicioClient oClient = new SolicitudServicioServices.SolicitudServicioClient();
                SolicitudServicioServices.SolicitudServicioDTO oSol = new SolicitudServicioServices.SolicitudServicioDTO();
                oSol.ComercioId = int.Parse(ddlCom.SelectedValue);
                oSol.MotivoSolicitudId = int.Parse(ddlMotSol.SelectedValue);
                oSol.TerminalSolicitadoId = int.Parse(ddlTerSol.SelectedValue);
                oSol.Estado = ddlEstado.SelectedValue;
                oSol.UsrReg = MySession.UserId;
                oClient.Registrar(oSol);
            }
            catch (Exception)
            {
                
                throw;
            }
            

        }
    }
}