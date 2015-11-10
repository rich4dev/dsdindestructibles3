using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class TipoDocumentoDTO
    {
        int tipodocumentoid;
        string descripcion;
        DateTime fechareg;
        int usrreg;
        DateTime fechamod;
        int usrmod;

        public TipoDocumentoDTO()
        {

        }

        [DataMember] 
        public virtual int TipoDocumentoId
        {
            get { return tipodocumentoid; }
            set { tipodocumentoid = value; }
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
        public virtual DateTime FechaReg
        {
            get { return fechareg; }
            set { fechareg = value; }
        }

        [DataMember] 
        public virtual int UsrReg
        {
            get { return usrreg; }
            set { usrreg = value; }
        }

        [DataMember] 
        public virtual DateTime FechaMod
        {
            get { return fechamod; }
            set { fechamod = value; }
        }

        [DataMember] 
        public virtual int UsrMod
        {
            get { return usrmod; }
            set { usrmod = value; }
        }


    }
}
