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
        public virtual int UsuarioId
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
        public virtual int TipoDocumentoId
        {
            get { return tipodocumentoid; }
            set { tipodocumentoid = value; }
        }

        [DataMember] 
        public virtual string NumeroDocumento
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
        public virtual int PerfilId
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
