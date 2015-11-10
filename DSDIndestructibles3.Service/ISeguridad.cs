using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSDIndestructibles3.Service
{
    
    [ServiceContract]
    public interface ISeguridad
    {
        [OperationContract]
        void Login(string username, string clave);
    }
}
