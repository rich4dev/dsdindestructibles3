using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class SolicitudServicioDTO
    {

        [DataMember(IsRequired =false)]
        public int SolicitudServicioId { get; set; }

        [DataMember(IsRequired =false)]
        public string Numero { get; set; }

        [DataMember(IsRequired =false)]
        public int ComercioId { get; set; }

        [DataMember(IsRequired =false)]
        public int MotivoSolicitudId { get; set; }

        [DataMember(IsRequired =false)]
        public int TerminalSolicitadoId { get; set; }

        [DataMember(IsRequired =false)]
        public int? TerminalInstaladoId { get; set; }

        [DataMember(IsRequired =false)]
        public string SerieFisicoAtn { get; set; }

        [DataMember(IsRequired =false)]
        public string SerieVirtualAtn { get; set; }

        [DataMember(IsRequired =false)]
        public string Capacitado { get; set; }

        [DataMember(IsRequired =false)]
        public string CapacitadoNombres { get; set; }

        [DataMember(IsRequired =false)]
        public string CapacitadoCargo { get; set; }

        [DataMember(IsRequired =false)]
        public DateTime? CapacitadoFecha { get; set; }

        [DataMember(IsRequired =false)]
        public string Senalizado { get; set; }

        [DataMember(IsRequired =false)]
        public string SenalizadoDescripcion { get; set; }

        [DataMember(IsRequired =false)]
        public string Estado { get; set; }

        [DataMember(IsRequired =false)]
        public int EmpresaId { get; set; }
        [DataMember(IsRequired = false)]
        public DateTime FechaReg { get; set; }
        [DataMember(IsRequired = false)]
        public int UsrReg { get; set; }
        [DataMember(IsRequired = false)]
        public DateTime? FechaMod { get; set; }
        [DataMember(IsRequired = false)]
        public int? UsrMod { get; set; }


        [DataMember(IsRequired =false)]
        public string ClienteRuc { get; set; }

        [DataMember(IsRequired =false)]
        public string ClienteRazonSocial { get; set; }

    }
}
