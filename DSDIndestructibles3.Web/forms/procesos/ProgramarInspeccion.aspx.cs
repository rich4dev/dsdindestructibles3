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

            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create(
                "http://localhost:29231/SolicitudAfiliacion.svc/GetSolicitudAfiliacionById?id=2");
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string solicitudJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();

            Solicitud_AfiliacionList solicitudObtenido = js.Deserialize<Solicitud_AfiliacionList>(solicitudJson2);
            Solicitud_AfiliacionDTO solicitudAfilicacion = js.Deserialize<Solicitud_AfiliacionDTO>(solicitudJson2);

            ltrSolicitudes.Text = "snkjdkaf";
        }
    }

    public class Solicitud_AfiliacionList
    {
        public List<Solicitud_AfiliacionDTO> lstSolicitud_AfiliacionDTO { get; set; }
    }
}