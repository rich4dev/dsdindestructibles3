using System.Collections.Generic;
using System.Text;
using System;
namespace DSDIndestructibles3.Entities
{
public class Empresa 
{
int empresaid;
string razonsocial;
String estado;
DateTime fechareg;
int usrreg;
DateTime fechamod;
int usrmod;

public Empresa()
{

}

public virtual int Empresaid
{
get { return empresaid; }
set { empresaid= value; }
}

public virtual string Razonsocial
{
get { return razonsocial; }
set { razonsocial= value; }
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
if(empresaid!=null)
	s+= "empresaid : "+ empresaid.ToString()+"\n";
else
	s+= "empresaid : null\n";
if(razonsocial!=null)
	s+= "razonsocial : "+ razonsocial.ToString()+"\n";
else
	s+= "razonsocial : null\n";
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
