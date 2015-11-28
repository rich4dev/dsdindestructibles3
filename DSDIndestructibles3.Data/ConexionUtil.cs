using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DSDIndestructibles3.Data
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=(local);Initial Catalog=testdsd;Integrated Security=SSPI;";
        }
    }
}
