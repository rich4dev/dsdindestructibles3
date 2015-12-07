using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSDIndestructibles3.Datos;
using System.Messaging;
using DSDIndestructibles3.Entities;

namespace DSDIndestructibles3.ConsoleApp
{
    class SolicitudServicioQueue
    {
        static void Main(string[] args)
        {
            SolicitudServicioData oSolicitudServicioData = new SolicitudServicioData();
            string rutaCola = @".\private$\SolicitudServicioRecibida";
            if (MessageQueue.Exists(rutaCola) == true)
            {
                MessageQueue cola = new MessageQueue(rutaCola);
                Message[] msgs = cola.GetAllMessages();
                SolicitudServicioDTO oSolicitudServicioDTO = new SolicitudServicioDTO();
                if (cola.GetAllMessages().Count() > 0)
                {
                    foreach (Message msg in cola.GetAllMessages())
                    {
                        msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(SolicitudServicioDTO) });
                        oSolicitudServicioDTO = (SolicitudServicioDTO)msg.Body;
                        if (oSolicitudServicioData.Get(oSolicitudServicioDTO.SolicitudServicioId) == null)
                        {
                            oSolicitudServicioData.Add(oSolicitudServicioDTO);
                        }
                        else
                        {
                            oSolicitudServicioData.Update(oSolicitudServicioDTO);
                        }
                        cola.Receive();
                    }
                }
            }
        }
    }
}
