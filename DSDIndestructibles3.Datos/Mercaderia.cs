using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace DSDIndestructibles3.Datos
{
    [Table("Mercaderia")]
    public class Mercaderia
    {
        public int MercaderiaId { get; set; }

        [StringLength(150)]
        public string Codigo { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

    }
}
