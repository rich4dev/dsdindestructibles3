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
    public partial class ProgramarInspeccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadData();
            }
        }

        public void LoadData() { 
        
            txtFecInsp.Text = DateTime.Today.ToShortDateString();
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create(
                "http://localhost:29231/SolicitudAfiliacion.svc/GetAllSolicitudAfiliaciones");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string solicitudJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();

            //Solicitud_AfiliacionList solicitudObtenido = js.Deserialize<Solicitud_AfiliacionList>(solicitudJson2);
            List<Solicitud_AfiliacionDTO> lstSolicitudAfiliacion = js.Deserialize<List<Solicitud_AfiliacionDTO>>(solicitudJson2);
            //Solicitud_AfiliacionDTO solicitudAfilicacion = js.Deserialize<Solicitud_AfiliacionDTO>(solicitudJson2);

            hdLstSolicitudes.Value = solicitudJson2;
            
        }
        
        protected void btnGrabarSolicitud_Click(object sender, EventArgs e) {

            try
            {
                DateTime date = new DateTime();
                date = DateTime.Parse(txtFecInsp.Text);
                string dateToMiliseconds = "" + (long)(date - new DateTime(1970, 1, 1)).TotalMilliseconds;

                string postdata =
                "{\"IdSolicitudAfiliacion\":\"" + hdSolicitudSave.Value +
                  "\",\"Referencias\":\"" + txtReferencias.Text +
                  "\",\"TecnicoAsignado\":\"" + ddlTecnicos.SelectedValue +
                  "\",\"Fecha\":\"\\/Date(" + dateToMiliseconds + ")\\/" +

                  "\",\"Hora\":\"" + txtHora.Text +
                  "\",\"EstadoActual\":\"" + ddlEstadoActual.SelectedValue + "\"}";

                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:29231/InspeccionService.svc/ProgramarInspeccion");
                req.Method = "POST";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                var res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string result = reader.ReadToEnd();

                JavaScriptSerializer js = new JavaScriptSerializer();
                InspeccionDTO newInspeccion = js.Deserialize<InspeccionDTO>(result);

                if (newInspeccion.IdInspeccion > 0)
                {
                    lblmessage.Text = "Se registró la solicitud existosamente.";
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('Se registró la solicitud existosamente.');</script>");

                    pnlRegistro.Visible = false;
                }
                else {
                    lblmessage.Text = "Error al registrar la inspección.";
                    //Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('Error al registrar la inspección.');</script>");
                }

            }
            catch {
                lblmessage.Text = "Error Inesperado.";
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('Error Inesperado.');</script>");

            }
        }

        protected void btnCargarSolicitud_Click(object sender, EventArgs e)
        {

            if (hdSolicitudSelect.Value == "") {
                lblmessage.Text = "Seleccione una solicitud.";
                //Page.ClientScript.RegisterStartupScript(this.GetType(), "showSaveMessageError", "<script language='javascript'>alert('Seleccione una solicitud.');</script>");
                return;
            }

            lblmessage.Text = "";
            string urlGet = "http://localhost:29231/SolicitudAfiliacion.svc/GetSolicitudAfiliacionById?id=" + hdSolicitudSelect.Value;



            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create(urlGet);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string solicitudJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();

            //Solicitud_AfiliacionList solicitudObtenido = js.Deserialize<Solicitud_AfiliacionList>(solicitudJson2);
            Solicitud_AfiliacionDTO SolicitudAfiliacionGet = js.Deserialize<Solicitud_AfiliacionDTO>(solicitudJson2);
            //Solicitud_AfiliacionDTO solicitudAfilicacion = js.Deserialize<Solicitud_AfiliacionDTO>(solicitudJson2);

            //hdLstSolicitudes.Value = solicitudJson2;
            lblTitle.Text = "Solicitud N°" + SolicitudAfiliacionGet.SolicitudAfiliacionID;
            hdSolicitudSave.Value = SolicitudAfiliacionGet.SolicitudAfiliacionID.ToString();
            txtRazonSocial.Text = SolicitudAfiliacionGet.RazonSocial;
            txtRuc.Text = SolicitudAfiliacionGet.RUC;
            txtDireccionComercial.Text = SolicitudAfiliacionGet.DireccionComercial;
            txtDireccionAdministrativa.Text = SolicitudAfiliacionGet.DireccionAdministrativa;
            txtRepresentanteLegal.Text = SolicitudAfiliacionGet.RepresentanteLegal1;
            txtPersonaContacto.Text = SolicitudAfiliacionGet.PersonaContactoPuntoVenta;

            pnlRegistro.Visible = true;
            //ltrSolicitudes.Text = "snkjdkaf";
        }

        public void limpiarCampos() {
            hdSolicitudSave.Value = "";
            txtRazonSocial.Text = "";
            txtRuc.Text = "";
            txtDireccionComercial.Text = "";
            txtDireccionAdministrativa.Text = "";
            txtRepresentanteLegal.Text = "";
            txtPersonaContacto.Text = "";

            txtFecInsp.Text = DateTime.Today.ToShortDateString();
            txtHora.Text = "";
            txtReferencias.Text = "";

        }
    }

}