using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using DSDIndestructibles3.Entities;
using System.ServiceModel.Web;

namespace DSDIndestructibles3.Test
{
    [TestClass]
    public class SolicitudServicio
    {
        [TestMethod]
        public void Registrar()
        {
            string cli = "1", mot = "1", ter = "1", est = "R";
            int userId = 1;
            string postdata =
                "{\"ComercioId\":\"" + cli + "\",\"MotivoSolicitudId\":\"" + mot +
                "\",\"TerminalSolicitadoId\":\"" + ter + "\",\"Estado\":\"" + est +
                "\",\"UsrReg\":\"" + userId.ToString() + "\"}";
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
            Assert.AreEqual("39", solicitud.SolicitudServicioId);
            Assert.AreEqual("1", solicitud.UsrReg);

        }
        [TestMethod]
        public void Obtener()
        {
            //http://localhost:29231/SolicitudServicio.svc/SolicitudServicio/Buscar/?idMotivo=1&?idComercio=1&?idModelo=1
            string id = "240";
            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:29231/SolicitudServicio.svc/SolicitudServicio/Obtener/?id=" + id);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string solicitudJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            SolicitudServicioDTO solicitudObtenido = js.Deserialize<SolicitudServicioDTO>(solicitudJson2);
            Assert.AreEqual(24, solicitudObtenido.SolicitudServicioId);
            Assert.AreEqual(1, solicitudObtenido.UsrReg);

        }
        [TestMethod]
        public void BuscarPorCampos()
        {
            //http://localhost:29231/SolicitudServicio.svc/SolicitudServicio/Buscar/?idMotivo=1&?idComercio=1&?idModelo=1
            string id = "13";

            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://localhost:29231/SolicitudServicio.svc/SolicitudServicio/Obtener/?id=" + id);
            req2.Method = "GET";
            HttpWebResponse res2 = (HttpWebResponse)req2.GetResponse();
            StreamReader reader2 = new StreamReader(res2.GetResponseStream());
            string solicitudJson2 = reader2.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            SolicitudServicioDTO solicitudObtenido = js.Deserialize<SolicitudServicioDTO>(solicitudJson2);
            Assert.AreEqual("12", solicitudObtenido.SolicitudServicioId);
            Assert.AreEqual("1", solicitudObtenido.UsrReg);
        }


        [TestMethod]
        public void AnyGeneric()
        {
            bool hitException = false;
            try
            {
                //throw new WebFaultException<int>();
            }
            catch (WebFaultException<string> e)
            {
                hitException = false;
            }
            catch (WebFaultException e)
            {
                hitException = true;
            }

            Assert.IsTrue(hitException);
        }
    }
}
