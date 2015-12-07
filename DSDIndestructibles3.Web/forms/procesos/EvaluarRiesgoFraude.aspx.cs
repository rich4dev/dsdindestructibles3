using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DSDIndestructibles3.Web.forms.procesos
{
    public partial class EvaluarRiesgoFraude : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        public void LimpiarCampos()
        {
            txtruc.Text = "";
            txtidcliente.Text = "";
            txtdirecomer.Text = "";
            txttelef.Text = "";
            txtmodelpos.Text = "";
            txtnom.Text = "";
            txtfechains.Text = "";
            txthorains.Text = "";
            txtobs.Text = "";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        protected void btnGuardar0_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            RiesgoFraude be = new RiesgoFraude();

            be.SRUC = txtruc.Text;
            be.CLIE = txtidcliente.Text = "";
            be.DIRECOM = txtdirecomer.Text = "";
            be.TELEF = txttelef.Text = "";
            be.MODELPOS = txtmodelpos.Text = "";
            be.NOM = txtnom.Text = "";
            be.FECHAINS = txtfechains.Text = "";
            be.HORAINS = txthorains.Text = "";
            be.OBS = txtobs.Text = "";


            service.GetData(be);

            lblmensaje.Text = "Se registro la solicitud : ID ";
            lblmensaje.Visible = true;
            LimpiarCampos();
        }
    }
}