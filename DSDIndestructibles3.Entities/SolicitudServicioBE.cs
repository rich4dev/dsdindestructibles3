using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class SolicitudServicioBE
    {
        int solicitudservicioid;
        int comercioid;
        int motivosolicitudid;
        int terminalsolicitadoid;
        int terminalinstalado;
        string seriefisicoatn;
        string serievirtualatn;
        String capacitado;
        string capacitadonombres;
        string capacitadocargo;
        DateTime capacitadofecha;
        String senalizado;
        string senalizadodescripcion;
        String estado;
        DateTime fechareg;
        int usrreg;
        DateTime fechamod;
        int usrmod;

        public SolicitudServicioBE()
        {

        }

        [DataMember] 
        public virtual int Solicitudservicioid
        {
            get { return solicitudservicioid; }
            set { solicitudservicioid = value; }
        }

        [DataMember] 
        public virtual int Comercioid
        {
            get { return comercioid; }
            set { comercioid = value; }
        }

        [DataMember] 
        public virtual int Motivosolicitudid
        {
            get { return motivosolicitudid; }
            set { motivosolicitudid = value; }
        }

        [DataMember] 
        public virtual int Terminalsolicitadoid
        {
            get { return terminalsolicitadoid; }
            set { terminalsolicitadoid = value; }
        }

        [DataMember] 
        public virtual int Terminalinstalado
        {
            get { return terminalinstalado; }
            set { terminalinstalado = value; }
        }

        [DataMember] 
        public virtual string Seriefisicoatn
        {
            get { return seriefisicoatn; }
            set { seriefisicoatn = value; }
        }

        [DataMember] 
        public virtual string Serievirtualatn
        {
            get { return serievirtualatn; }
            set { serievirtualatn = value; }
        }

        [DataMember] 
        public virtual String Capacitado
        {
            get { return capacitado; }
            set { capacitado = value; }
        }

        [DataMember] 
        public virtual string Capacitadonombres
        {
            get { return capacitadonombres; }
            set { capacitadonombres = value; }
        }

        [DataMember] 
        public virtual string Capacitadocargo
        {
            get { return capacitadocargo; }
            set { capacitadocargo = value; }
        }

        [DataMember] 
        public virtual DateTime Capacitadofecha
        {
            get { return capacitadofecha; }
            set { capacitadofecha = value; }
        }

        [DataMember] 
        public virtual String Senalizado
        {
            get { return senalizado; }
            set { senalizado = value; }
        }

        [DataMember] 
        public virtual string Senalizadodescripcion
        {
            get { return senalizadodescripcion; }
            set { senalizadodescripcion = value; }
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
            if (solicitudservicioid != null)
                s += "solicitudservicioid : " + solicitudservicioid.ToString() + "\n";
            else
                s += "solicitudservicioid : null\n";
            if (comercioid != null)
                s += "comercioid : " + comercioid.ToString() + "\n";
            else
                s += "comercioid : null\n";
            if (motivosolicitudid != null)
                s += "motivosolicitudid : " + motivosolicitudid.ToString() + "\n";
            else
                s += "motivosolicitudid : null\n";
            if (terminalsolicitadoid != null)
                s += "terminalsolicitadoid : " + terminalsolicitadoid.ToString() + "\n";
            else
                s += "terminalsolicitadoid : null\n";
            if (terminalinstalado != null)
                s += "terminalinstalado : " + terminalinstalado.ToString() + "\n";
            else
                s += "terminalinstalado : null\n";
            if (seriefisicoatn != null)
                s += "seriefisicoatn : " + seriefisicoatn.ToString() + "\n";
            else
                s += "seriefisicoatn : null\n";
            if (serievirtualatn != null)
                s += "serievirtualatn : " + serievirtualatn.ToString() + "\n";
            else
                s += "serievirtualatn : null\n";
            if (capacitado != null)
                s += "capacitado : " + capacitado.ToString() + "\n";
            else
                s += "capacitado : null\n";
            if (capacitadonombres != null)
                s += "capacitadonombres : " + capacitadonombres.ToString() + "\n";
            else
                s += "capacitadonombres : null\n";
            if (capacitadocargo != null)
                s += "capacitadocargo : " + capacitadocargo.ToString() + "\n";
            else
                s += "capacitadocargo : null\n";
            if (capacitadofecha != null)
                s += "capacitadofecha : " + capacitadofecha.ToString() + "\n";
            else
                s += "capacitadofecha : null\n";
            if (senalizado != null)
                s += "senalizado : " + senalizado.ToString() + "\n";
            else
                s += "senalizado : null\n";
            if (senalizadodescripcion != null)
                s += "senalizadodescripcion : " + senalizadodescripcion.ToString() + "\n";
            else
                s += "senalizadodescripcion : null\n";
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
