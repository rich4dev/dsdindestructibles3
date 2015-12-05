using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class Solicitud_AfiliacionDTO
    {
        [DataMember(IsRequired = false)]
        public int SolicitudAfiliacionID;
        [DataMember(IsRequired = false)]
        public string RUC;
        [DataMember(IsRequired = false)]
        public string RazonSocial;
        [DataMember(IsRequired = false)]
        public string NombreComercial;
        [DataMember(IsRequired = false)]
        public string DireccionComercial;
        [DataMember(IsRequired = false)]
        public string DireccionAdministrativa;
        [DataMember(IsRequired = false)]
        public string RepresentanteLegal1;
        [DataMember(IsRequired = false)]
        public string RepresentanteLegal2;
        [DataMember(IsRequired = false)]
        public string PersonaContactoPuntoVenta;
        [DataMember(IsRequired = false)]
        public string NumeroCuentaBancaria;
        [DataMember(IsRequired = false)]
        public string TipoCuenta;
        [DataMember(IsRequired = false)]
        public string TipoMoneda;
        [DataMember(IsRequired = false)]
        public string EntidadFinanciera;
        [DataMember(IsRequired = false)]
        public string TipoAFiliacion;
        [DataMember(IsRequired = false)]
        public string TipoProduccto;
        [DataMember(IsRequired = false)]
        public string TipoComunicacion;
        [DataMember(IsRequired = false)]
        public string FechaInstalacion;
    }
}
