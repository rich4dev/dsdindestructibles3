using System.Collections.Generic;
using System.Text;
using System;
namespace DSDIndestructibles3.Entities
{
public class Terminal 
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

public Terminal()
{

}

public virtual int Terminalid
{
get { return terminalid; }
set { terminalid= value; }
}

public virtual string Tipo
{
get { return tipo; }
set { tipo= value; }
}

public virtual string Comunicacion
{
get { return comunicacion; }
set { comunicacion= value; }
}

public virtual string Modelo
{
get { return modelo; }
set { modelo= value; }
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
if(terminalid!=null)
	s+= "terminalid : "+ terminalid.ToString()+"\n";
else
	s+= "terminalid : null\n";
if(tipo!=null)
	s+= "tipo : "+ tipo.ToString()+"\n";
else
	s+= "tipo : null\n";
if(comunicacion!=null)
	s+= "comunicacion : "+ comunicacion.ToString()+"\n";
else
	s+= "comunicacion : null\n";
if(modelo!=null)
	s+= "modelo : "+ modelo.ToString()+"\n";
else
	s+= "modelo : null\n";
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
