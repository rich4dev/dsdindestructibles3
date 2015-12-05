namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inspeccion")]
    public partial class Inspeccion
    {
        [Key]
        public int IdInspeccion { get; set; }
        public int IdSolicitudAfiliacion { get; set; }
        public string Referencias { get; set; }
        public string TecnicoAsignado { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public int EstadoActual { get; set; }
    }
}
