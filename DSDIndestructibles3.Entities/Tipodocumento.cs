using System.Collections.Generic;
using System.Text;
using System;
namespace DSDIndestructibles3.Entities
{
public class Tipodocumento 
{
int tipodocumentoid;
string descripcion;
DateTime fechareg;
int usrreg;
DateTime fechamod;
int usrmod;

public Tipodocumento()
{

}

public virtual int Tipodocumentoid
{
get { return tipodocumentoid; }
set { tipodocumentoid= value; }
}

public virtual string Descripcion
{
get { return descripcion; }
set { descripcion= value; }
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
if(tipodocumentoid!=null)
	s+= "tipodocumentoid : "+ tipodocumentoid.ToString()+"\n";
else
	s+= "tipodocumentoid : null\n";
if(descripcion!=null)
	s+= "descripcion : "+ descripcion.ToString()+"\n";
else
	s+= "descripcion : null\n";
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
