//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSDIndestructibles3.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Login { get; set; }
        public Nullable<int> TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public string Clave { get; set; }
        public Nullable<int> PerfilId { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public Nullable<int> UsrReg { get; set; }
        public Nullable<System.DateTime> FechaMod { get; set; }
        public Nullable<int> UsrMod { get; set; }
    }
}