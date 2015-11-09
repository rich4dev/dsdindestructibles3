using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;
namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class UsuarioBE
    {
        int usuarioid;
        string nombres;
        string apellidos;
        string login;
        int tipodocumentoid;
        string numerodocumento;
        string clave;
        int perfilid;
        String estado;
        DateTime fechareg;
        int usrreg;
        DateTime fechamod;
        int usrmod;

        public UsuarioBE()
        {

        }

        [DataMember] 
        public virtual int Usuarioid
        {
            get { return usuarioid; }
            set { usuarioid = value; }
        }

        [DataMember] 
        public virtual string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        [DataMember] 
        public virtual string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [DataMember] 
        public virtual string Login
        {
            get { return login; }
            set { login = value; }
        }

        [DataMember] 
        public virtual int Tipodocumentoid
        {
            get { return tipodocumentoid; }
            set { tipodocumentoid = value; }
        }

        [DataMember] 
        public virtual string Numerodocumento
        {
            get { return numerodocumento; }
            set { numerodocumento = value; }
        }

        [DataMember] 
        public virtual string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        [DataMember] 
        public virtual int Perfilid
        {
            get { return perfilid; }
            set { perfilid = value; }
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
            if (usuarioid != null)
                s += "usuarioid : " + usuarioid.ToString() + "\n";
            else
                s += "usuarioid : null\n";
            if (nombres != null)
                s += "nombres : " + nombres.ToString() + "\n";
            else
                s += "nombres : null\n";
            if (apellidos != null)
                s += "apellidos : " + apellidos.ToString() + "\n";
            else
                s += "apellidos : null\n";
            if (login != null)
                s += "login : " + login.ToString() + "\n";
            else
                s += "login : null\n";
            if (tipodocumentoid != null)
                s += "tipodocumentoid : " + tipodocumentoid.ToString() + "\n";
            else
                s += "tipodocumentoid : null\n";
            if (numerodocumento != null)
                s += "numerodocumento : " + numerodocumento.ToString() + "\n";
            else
                s += "numerodocumento : null\n";
            if (clave != null)
                s += "clave : " + clave.ToString() + "\n";
            else
                s += "clave : null\n";
            if (perfilid != null)
                s += "perfilid : " + perfilid.ToString() + "\n";
            else
                s += "perfilid : null\n";
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
