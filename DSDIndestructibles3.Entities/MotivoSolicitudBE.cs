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
        public virtual int Motivosolicitudid
        {
            get { return motivosolicitudid; }
            set { motivosolicitudid = value; }
        }

        [DataMember] 
        public virtual string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        [DataMember] 
        public virtual String Estado
        {
            get { return estado; }
            set { estado = value; }
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
            if (motivosolicitudid != null)
                s += "motivosolicitudid : " + motivosolicitudid.ToString() + "\n";
            else
                s += "motivosolicitudid : null\n";
            if (descripcion != null)
                s += "descripcion : " + descripcion.ToString() + "\n";
            else
                s += "descripcion : null\n";
            if (estado != null)
                s += "estado : " + estado.ToString() + "\n";
            else
                s += "estado : null\n";
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
