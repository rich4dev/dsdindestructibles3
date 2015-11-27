using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSDIndestructibles3.Service
{
    [ServiceContract]
    public interface IClienteService
    {
   //Lista clientes
        [OperationContract]
        List<ClienteDTO> GetAll();
    }
}
