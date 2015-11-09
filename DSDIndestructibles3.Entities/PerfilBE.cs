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
        public virtual int Perfilid
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
        public virtual DateTime Fechareg
        {
            get { return fechareg; }
            set { fechareg = value; }
        }

        [DataMember] 
        public virtual int Usrreg
        {
            get { return usrreg; }
            set { usrreg = value; }
        }

        [DataMember] 
        public virtual DateTime Fechamod
        {
            get { return fechamod; }
            set { fechamod = value; }
        }

        [DataMember] 
        public virtual int Usrmod
        {
            get { return usrmod; }
            set { usrmod = value; }
        }

        public override string ToString()
        {
            String s = "";
            if (perfilid != null)
                s += "perfilid : " + perfilid.ToString() + "\n";
            else
                s += "perfilid : null\n";
            if (descripcion != null)
                s += "descripcion : " + descripcion.ToString() + "\n";
            else
                s += "descripcion : null\n";
            if (fechareg != null)
                s += "fechareg : " + fechareg.ToString() + "\n";
            else
                s += "fechareg : null\n";
            if (usrreg != null)
                s += "usrreg : " + usrreg.ToString() + "\n";
            else
                s += "usrreg : null\n";
            if (fechamod != null)
                s += "fechamod : " + fechamod.ToString() + "\n";
            else
                s += "fechamod : null\n";
            if (usrmod != null)
                s += "usrmod : " + usrmod.ToString() + "\n";
            else
                s += "usrmod : null\n";
            return s;
        }


    }
}
