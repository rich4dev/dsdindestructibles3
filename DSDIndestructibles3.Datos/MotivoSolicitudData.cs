using AutoMapper;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDIndestructibles3.Datos
{
    public class MotivoSolicitudData
    {
        public List<MotivoSolicitudDTO> GetAll()
        {
            var lista = new List<MotivoSolicitudDTO>();
            var listaQuery = new object();
            using (Model1 context =
               new Model1())
            {
                lista = context.MotivoSolicitud
                    .Select(x => new MotivoSolicitudDTO()
                    {
                        MotivoSolicitudId = x.MotivoSolicitudId,
                        Descripcion = x.Descripcion,
                        Estado = x.Estado
                    }).ToList();
            }
            return lista;
        }

    }
}
