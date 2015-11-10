using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class MotivoSolicitudBE
    {
        int motivosolicitudid;
        string descripcion;
        String estado;
        DateTime fechareg;
        int usrreg;
        DateTime fechamod;
        int usrmod;

        public MotivoSolicitudBE()
        {

        }

        [DataMember]
        public int MotivoSolicitudId { get; set; }

        [DataMember] 
        public string Descripcion { get; set; }

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
