using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class PerfilBE
    {
        int perfilid;
        string descripcion;
        DateTime fechareg;
        int usrreg;
        DateTime fechamod;
        int usrmod;

        public PerfilBE()
        {

        }

        [DataMember]
        public virtual int PerfilId
        {
            get { return perfilid; }
            set { perfilid = value; }
        }

        [DataMember]
        public virtual string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
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
