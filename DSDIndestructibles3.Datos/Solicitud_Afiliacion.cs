namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudAfiliacion")]
    public partial class Solicitud_Afiliacion
    {
        [Key]
        public int SolicitudAfiliacionID { get; set; }
        public string RUC { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string DireccionComercial { get; set; }
        public string DireccionAdministrativa { get; set; }
        public string RepresentanteLegal1 { get; set; }
        public string RepresentanteLegal2 { get; set; }
        public string PersonaContactoPuntoVenta { get; set; }
        public string NumeroCuentaBancaria { get; set; }
        public string TipoCuenta { get; set; }
        public string TipoMoneda { get; set; }
        public string EntidadFinanciera { get; set; }
        public string TipoAFiliacion { get; set; }
        public string TipoProduccto { get; set; }
        public string TipoComunicacion { get; set; }
        public string FechaInstalacion { get; set; }


    }
}
