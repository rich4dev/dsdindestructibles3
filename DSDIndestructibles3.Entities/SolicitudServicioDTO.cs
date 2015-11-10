using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class SolicitudServicioDTO
    {

        [DataMember]
        public int SolicitudServicioId { get; set; }

        [DataMember]
        public string Numero { get; set; }

        [DataMember]
        public int ComercioId { get; set; }

        [DataMember]
        public int MotivoSolicitudId { get; set; }

        [DataMember]
        public int TerminalSolicitadoId { get; set; }

        [DataMember]
        public int? TerminalInstaladoId { get; set; }

        [DataMember]
        public string SerieFisicoAtn { get; set; }

        [DataMember]
        public string SerieVirtualAtn { get; set; }

        [DataMember]
        public string Capacitado { get; set; }

        [DataMember]
        public string CapacitadoNombres { get; set; }

        [DataMember]
        public string CapacitadoCargo { get; set; }

        [DataMember]
        public DateTime? CapacitadoFecha { get; set; }

        [DataMember]
        public string Senalizado { get; set; }

        [DataMember]
        public string SenalizadoDescripcion { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public int EmpresaId { get; set; }
        [DataMember]
        public DateTime FechaReg { get; set; }
        [DataMember]
        public int UsrReg { get; set; }
        [DataMember]
        public DateTime? FechaMod { get; set; }
        [DataMember]
        public int? UsrMod { get; set; }


        [DataMember]
        public string ClienteRuc { get; set; }

        [DataMember]
        public string ClienteRazonSocial { get; set; }

    }
}
