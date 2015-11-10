namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        public int UsuarioId { get; set; }

        [StringLength(150)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string Apellidos { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        public int? TipoDocumentoId { get; set; }

        [StringLength(50)]
        public string NumeroDocumento { get; set; }

        [StringLength(50)]
        public string Clave { get; set; }

        public int? PerfilId { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime? FechaReg { get; set; }

        public int? UsrReg { get; set; }

        public DateTime? FechaMod { get; set; }

        public int? UsrMod { get; set; }
    }
}
