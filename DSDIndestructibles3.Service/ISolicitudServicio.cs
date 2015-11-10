using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSDIndestructibles3.Service
{
    [ServiceContract]
    public interface ISolicitudServicio
    {
        [OperationContract]
        void Registrar(SolicitudServicioBE oSolicitudServicioBE);
        [OperationContract]
        void Actualizar(SolicitudServicioBE oSolicitudServicioBE);
        [OperationContract]
        void Eliminar(int id);
        [OperationContract]
        SolicitudServicioBE Obtener(int id);
        [OperationContract]
        List<SolicitudServicioBE> ListarBandeja(DateTime fechaDesde, DateTime fechaHasta, string estado, int empresaId);
    }
}
