using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSDIndestructibles3.Test
{
    [TestClass]
    public class SolicitudServicio
    {
        [TestMethod]
        public void Registrar()
        {
            Services.SolicitudServicio.SolicitudServicioClient oClient = new Services.SolicitudServicio.SolicitudServicioClient();

            Services.SolicitudServicio.SolicitudServicioBE oSolicitud = new Services.SolicitudServicio.SolicitudServicioBE();
            oSolicitud.SolicitudServicioId = 1;
            oSolicitud.Capacitado = "1";
            oSolicitud.CapacitadoCargo = "Cajero";
            oSolicitud.CapacitadoFecha = DateTime.Today;
            oSolicitud.CapacitadoNombres = "TEST RICARDO";
            oSolicitud.ComercioId = 1;
            oSolicitud.EmpresaId = 1;
            oSolicitud.Estado = "A";
            oSolicitud.FechaReg = DateTime.Today;
            oSolicitud.MotivoSolicitudId = 1;
            oSolicitud.SerieFisicoAtn = "3214121421";
            oSolicitud.TerminalInstaladoId = 1;
            oClient.Registrar(oSolicitud);
        }
        [TestMethod]
        public void Modificar()
        {
            Services.SolicitudServicio.SolicitudServicioClient oClient = new Services.SolicitudServicio.SolicitudServicioClient();

            Services.SolicitudServicio.SolicitudServicioBE oSolicitud = new Services.SolicitudServicio.SolicitudServicioBE();
            oSolicitud.SolicitudServicioId = 1;
            oSolicitud.Capacitado = "1";
            oSolicitud.CapacitadoCargo = "Cajero";
            oSolicitud.CapacitadoFecha = DateTime.Today;
            oSolicitud.CapacitadoNombres = "TEST RICARDO";
            oSolicitud.ComercioId = 1;
            oSolicitud.EmpresaId = 1;
            oSolicitud.Estado = "A";
            oSolicitud.FechaReg = DateTime.Today;
            oSolicitud.MotivoSolicitudId = 1;
            oSolicitud.SerieFisicoAtn = "3214121421";
            oSolicitud.TerminalInstaladoId = 1;
            oClient.Actualizar(oSolicitud);
        }
    }
}
