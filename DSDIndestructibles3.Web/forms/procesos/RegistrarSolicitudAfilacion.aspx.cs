using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DSDIndestructibles3.Datos;
namespace DSDIndestructibles3.Web.forms.procesos
{
    public partial class RegistrarSolicitudAfilacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngrabar_Click(object sender, EventArgs e)
        {
            //  DSDIndestructible.SOAP.Service1 service = new DSDIndestructible.SOAP.Service1();
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            SolicitudAfiliacion be = new SolicitudAfiliacion();

            be.SRUC = txtruc.Text;
            be.SRAZO_SOCI = txtrazonsocial.Text;
            be.SNOMB_COME = txtnombrecomercial.Text;
            be.SDIRE_COME = txtdirecomercial.Text;
            be.SDIRE_ADMI = txtdirecomercial.Text;
            be.SREPR_LEGA_1 = txtrepresenante1.Text;
            be.SREPR_LEGA_2 = txtrepresentante2.Text;
            be.SPERS_CONT = txtpersonalcontacto.Text;
            be.SNUME_CUEN = txtcuentabancaria.Text;
            be.STIPO_CUEN = txtipocuenta.Text;
            be.SMONE = txtmoneda.Text;
            be.SENTI_FINA = txtentidadfinanciera.Text;
            be.STIPO_AFIL = txttipoafiliacion.Text;
            be.STIPO_PROD = txttipoproducto.Text;
            be.STIPO_COMU = txttipocomunicacion.Text;
            be.SFECH_INST = txtfechainstalacion.Text;

            service.GetData(be);
         
            lblmensaje.Text = "Se registro la solicitud : ID ";
            lblmensaje.Visible = true;
            LimpiarCampos();
            //txtNombre.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text)).Nombre;
            //txtPaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_paterno;
            //txtMaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_materno;
            //txtSexo.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Sexo;
            //txtEstadoCivil.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Est_civil1;
            //txtNacionalidad.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Nacionalidad;
            //txtDepartamento.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Departamento1;
            //txtProvincia.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Provincia;
            //txtDistrito.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Distrito;
            //txtDomicilio.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Domicilio1;
            //imgFoto.ImageUrl = "~/FOTOS/" + service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Foto;

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
          //  DSDIndestructible.SOAP.Service1 service = new DSDIndestructible.SOAP.Service1();
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            SolicitudAfiliacion be = new SolicitudAfiliacion();

            be.SRUC        = txtruc.Text;
            be.SRAZO_SOCI  =txtrazonsocial.Text;
            be.SNOMB_COME  =txtnombrecomercial.Text;
            be.SDIRE_COME  =txtdirecomercial.Text;
            be.SDIRE_ADMI  =txtdirecomercial.Text;
            be.SREPR_LEGA_1=txtrepresenante1.Text;
            be.SREPR_LEGA_2=txtrepresentante2.Text;
            be.SPERS_CONT  =txtpersonalcontacto.Text;
            be.SNUME_CUEN  =txtcuentabancaria.Text;
            be.STIPO_CUEN  =txtipocuenta.Text;
            be.SMONE       =txtmoneda.Text;
            be.SENTI_FINA  =txtentidadfinanciera.Text;
            be.STIPO_AFIL  =txttipoafiliacion.Text;
            be.STIPO_PROD  =txttipoproducto.Text;
            be.STIPO_COMU  =txttipocomunicacion.Text;
            be.SFECH_INST = txtfechainstalacion.Text;

            service.GetData(be);
            lblmensaje.Text = "Se registro chulll";
            lblmensaje.Visible = true;
            LimpiarCampos();
            //txtNombre.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text)).Nombre;
            //txtPaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_paterno;
            //txtMaterno.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Ape_materno;
            //txtSexo.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Sexo;
            //txtEstadoCivil.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Est_civil1;
            //txtNacionalidad.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Nacionalidad;
            //txtDepartamento.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Departamento1;
            //txtProvincia.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Provincia;
            //txtDistrito.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Distrito;
            //txtDomicilio.Text = service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Domicilio1;
            //imgFoto.ImageUrl = "~/FOTOS/" + service.Obtener_Reniec(Convert.ToInt32(txtBuscar_DNI.Text.ToString())).Foto;
        }

        public void LimpiarCampos() {
            txtruc.Text = "";
            txtrazonsocial.Text = "";
            txtnombrecomercial.Text = "";
            txtdirecomercial.Text = "";
            txtdirecadmin.Text = "";
            txtrepresenante1.Text = "";
            txtrepresentante2.Text = "";
            txtpersonalcontacto.Text = "";
            txtcuentabancaria.Text = "";
            txtipocuenta.Text = "";
            txtmoneda.Text = "";
            txtentidadfinanciera.Text = "";
            txttipoafiliacion.Text = "";
            txttipoproducto.Text = "";
            txttipocomunicacion.Text = "";
            txtfechainstalacion.Text = "";
            
        }

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}