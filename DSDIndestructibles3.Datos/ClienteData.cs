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
    public class ClienteData
    {
        public List<ClienteDTO> GetAll()
        {
            var lista = new List<ClienteDTO>();
            var listaQuery = new object();
            using (Model1 context =
               new Model1())
            {
                lista = context.Cliente
                    .Select(x => new ClienteDTO()
                    {
                        Contacto = x.Contacto,
                        Descripcion = x.Ruc + " - " + x.RazonSocial,
                        Ruc = x.Ruc,
                        RazonSocial = x.RazonSocial,
                        Direccion = x.Direccion,
                        Estado = x.Estado
                    }).ToList();
            }
            return lista;
        }

    }
}
