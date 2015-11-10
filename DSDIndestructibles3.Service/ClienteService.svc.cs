using DSDIndestructibles3.Datos;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


namespace DSDIndestructibles3.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClienteService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClienteService.svc or ClienteService.svc.cs at the Solution Explorer and start debugging.
    public class ClienteService : IClienteService
    {
        private ClienteData clienteDAO = null;
        private ClienteData ClienteDAO
        {
            get
            {
                if (clienteDAO == null)
                    clienteDAO = new ClienteData();
                return clienteDAO;
            }
        }

        public List<Entities.ClienteDTO> GetAll()
        {
            return ClienteDAO.GetAll();
        }
    }
}
