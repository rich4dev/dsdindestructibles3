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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MotivoSolicitudService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MotivoSolicitudService.svc or MotivoSolicitudService.svc.cs at the Solution Explorer and start debugging.
    public class MotivoSolicitudService : IMotivoSolicitudService
    {
        private MotivoSolicitudData motivoSolicitudDAO = null;
        private MotivoSolicitudData MotivoSolicitudDAO
        {
            get
            {
                if (motivoSolicitudDAO == null)
                    motivoSolicitudDAO = new MotivoSolicitudData();
                return motivoSolicitudDAO;
            }
        }

        public List<MotivoSolicitudDTO> GetAll()
        {
            return MotivoSolicitudDAO.GetAll();
        }
    }
}
