namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudServicio")]
    public partial class SolicitudServicio
    {
        [Key]
        public int SolicitudServicioId { get; set; }

        public int? ComercioId { get; set; }

        public int? MotivoSolicitudId { get; set; }

        public int? TerminalSolicitadoId { get; set; }

        public int? TerminalInstaladoId { get; set; }

        [StringLength(50)]
        public string SerieFisicoAtn { get; set; }

        [StringLength(50)]
        public string SerieVirtualAtn { get; set; }

        [StringLength(1)]
        public string Capacitado { get; set; }

        [StringLength(50)]
        public string CapacitadoNombres { get; set; }

        [StringLength(50)]
        public string CapacitadoCargo { get; set; }

        public DateTime? CapacitadoFecha { get; set; }

        [StringLength(1)]
        public string Senalizado { get; set; }

        [StringLength(150)]
        public string SenalizadoDescripcion { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public int? EmpresaId { get; set; }

        public DateTime? FechaReg { get; set; }

        public int? UsrReg { get; set; }

        public DateTime? FechaMod { get; set; }

        public int? UsrMod { get; set; }
    }
}
