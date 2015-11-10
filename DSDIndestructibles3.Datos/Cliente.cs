namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cliente")]
    public partial class Cliente
    {
        public int ClienteId { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        [StringLength(150)]
        public string Ruc { get; set; }

        [StringLength(150)]
        public string RazonSocial { get; set; }

        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(150)]
        public string Contacto { get; set; }

        public int? UbigeoId { get; set; }

        [StringLength(1)]
        public string Estado { get; set; }

        public DateTime? FechaReg { get; set; }

        public int? UsrReg { get; set; }

        public DateTime? FechaMod { get; set; }

        public int? UsrMod { get; set; }
    }
}
