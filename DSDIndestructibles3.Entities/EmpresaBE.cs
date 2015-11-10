using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class EmpresaBE
    {
        [DataMember]
        public int EmpresaId { get; set; }
        [DataMember]
        public string RazonSocial { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public DateTime FechaReg { get; set; }
        [DataMember]
        public int UsrReg { get; set; }
        [DataMember]
        public DateTime FechaMod { get; set; }
        [DataMember]
        public int UsrMod { get; set; }
    }
}
