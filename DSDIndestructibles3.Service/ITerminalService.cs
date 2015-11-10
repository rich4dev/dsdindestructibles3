using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DSDIndestructibles3.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITerminalService" in both code and config file together.
    [ServiceContract]
    public interface ITerminalService
    {
        [OperationContract]
        List<TerminalDTO> GetAll();
    }
}
