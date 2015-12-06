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
    }
}