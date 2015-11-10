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
    public class TerminalData
    {
        public List<TerminalDTO> GetAll()
        {
            var lista = new List<TerminalDTO>();
            var listaQuery = new object();
            using (Model1 context =
               new Model1())
            {
                lista = context.Terminal
                    .Select(x => new TerminalDTO()
                    {
                        TerminalId = x.TerminalId,
                        Descripcion = x.Tipo + "-" + x.Comunicacion + "-" + x.Modelo,
                        Estado = x.Estado
                    }).ToList();
            }
            return lista;
        }

    }
}
