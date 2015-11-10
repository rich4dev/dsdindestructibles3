using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class TerminalDTO
    {
        int terminalid;
        string tipo;
        string comunicacion;
        string modelo;
        String estado;
        DateTime fechareg;
        int usrreg;
        DateTime fechamod;
        int usrmod;

        public TerminalDTO()
        {

        }

        [DataMember] 
        public virtual int TerminalId
        {
            get { return terminalid; }
            set { terminalid = value; }
        }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember] 
        public virtual string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        [DataMember] 
        public virtual string Comunicacion
        {
            get { return comunicacion; }
            set { comunicacion = value; }
        }

        [DataMember] 
        public virtual string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
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
