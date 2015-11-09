using System.Collections.Generic;
using System.Text;
using System;
namespace DSDIndestructibles3.Entities
{
public class Cliente 
{
int clienteid;
string descripcion;
string ruc;
string razonsocial;
string direccion;
string contacto;
int ubigeoid;
String estado;
DateTime fechareg;
int usrreg;
DateTime fechamod;
int usrmod;

public Cliente()
{

}

public virtual int Clienteid
{
get { return clienteid; }
set { clienteid= value; }
}

public virtual string Descripcion
{
get { return descripcion; }
set { descripcion= value; }
}

public virtual string Ruc
{
get { return ruc; }
set { ruc= value; }
}

public virtual string Razonsocial
{
get { return razonsocial; }
set { razonsocial= value; }
}

public virtual string Direccion
{
get { return direccion; }
set { direccion= value; }
}

public virtual string Contacto
{
get { return contacto; }
set { contacto= value; }
}

public virtual int Ubigeoid
{
get { return ubigeoid; }
set { ubigeoid= value; }
}

public virtual String Estado
{
get { return estado; }
set { estado= value; }
}

public virtual DateTime Fechareg
{
get { return fechareg; }
set { fechareg= value; }
}

public virtual int Usrreg
{
get { return usrreg; }
set { usrreg= value; }
}

public virtual DateTime Fechamod
{
get { return fechamod; }
set { fechamod= value; }
}

public virtual int Usrmod
{
get { return usrmod; }
set { usrmod= value; }
}

public override string ToString()
{
String s = "";
if(clienteid!=null)
	s+= "clienteid : "+ clienteid.ToString()+"\n";
else
	s+= "clienteid : null\n";
if(descripcion!=null)
	s+= "descripcion : "+ descripcion.ToString()+"\n";
else
	s+= "descripcion : null\n";
if(ruc!=null)
	s+= "ruc : "+ ruc.ToString()+"\n";
else
	s+= "ruc : null\n";
if(razonsocial!=null)
	s+= "razonsocial : "+ razonsocial.ToString()+"\n";
else
	s+= "razonsocial : null\n";
if(direccion!=null)
	s+= "direccion : "+ direccion.ToString()+"\n";
else
	s+= "direccion : null\n";
if(contacto!=null)
	s+= "contacto : "+ contacto.ToString()+"\n";
else
	s+= "contacto : null\n";
if(ubigeoid!=null)
	s+= "ubigeoid : "+ ubigeoid.ToString()+"\n";
else
	s+= "ubigeoid : null\n";
if(estado!=null)
	s+= "estado : "+ estado.ToString()+"\n";
else
	s+= "estado : null\n";
if(fechareg!=null)
	s+= "fechareg : "+ fechareg.ToString()+"\n";
else
	s+= "fechareg : null\n";
if(usrreg!=null)
	s+= "usrreg : "+ usrreg.ToString()+"\n";
else
	s+= "usrreg : null\n";
if(fechamod!=null)
	s+= "fechamod : "+ fechamod.ToString()+"\n";
else
	s+= "fechamod : null\n";
if(usrmod!=null)
	s+= "usrmod : "+ usrmod.ToString()+"\n";
else
	s+= "usrmod : null\n";
return s;
}


}
}
