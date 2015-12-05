using System.Collections.Generic;
using System.Text;
using System;
using System.Runtime.Serialization;

namespace DSDIndestructibles3.Entities
{
    [DataContract]
    public class InspeccionDTO
    {	
        [DataMember(IsRequired = false)]
        public int IdInspeccion;			
        	
        [DataMember(IsRequired = false)]
       	public int IdSolicitudAfiliacion;	
        	
        [DataMember(IsRequired = false)]
       	public string Referencias;
        	
        [DataMember(IsRequired = false)]
       	public string TecnicoAsignado;
       	
        [DataMember(IsRequired = false)]
       	public DateTime Fecha;
        	
        [DataMember(IsRequired = false)]
       	public string Hora;

        [DataMember(IsRequired = false)]
        public int EstadoActual;


    }
}
