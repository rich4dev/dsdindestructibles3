using DSDIndestructibles3.Datos;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DSDIndestructibles3.Service
{
    public class InspeccionService : IInspeccionService
    {

        private InspeccionData inspeccionDAO = null;
        private InspeccionData InspeccionDAO
        {
            get
            {
                if (inspeccionDAO == null)
                    inspeccionDAO = new InspeccionData();
                return inspeccionDAO;
            }
        }
        public InspeccionDTO ProgramarInspeccion(InspeccionDTO oInspeccion)
        {
            int id = InspeccionDAO.Add(oInspeccion);
            
            var response = new InspeccionDTO();
            response.IdInspeccion = id;
            //var obj = InspeccionDAO.Get(id);
            return response;
        }
    }
}
