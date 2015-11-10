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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TerminalService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TerminalService.svc or TerminalService.svc.cs at the Solution Explorer and start debugging.
    public class TerminalService : ITerminalService
    {
        private TerminalData terminalDAO = null;
        private TerminalData TerminalDAO
        {
            get
            {
                if (terminalDAO == null)
                    terminalDAO = new TerminalData();
                return terminalDAO;
            }
        }

        public List<Entities.TerminalDTO> GetAll()
        {
            return TerminalDAO.GetAll();
        }
    }
}
