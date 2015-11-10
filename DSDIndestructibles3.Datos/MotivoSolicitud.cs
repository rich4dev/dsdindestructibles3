namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoSolicitud")]
    public partial class MotivoSolicitud
    {
        public int MotivoSolicitudId { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime? FechaReg { get; set; }

        public int? UsrReg { get; set; }

        public DateTime? FechaMod { get; set; }

        public int? UsrMod { get; set; }
    }
}
