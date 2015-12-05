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
    public class InspeccionData
    {
        public int Add(InspeccionDTO entidad)
        {
            int id = 0;
            Mapper.CreateMap<InspeccionDTO, Inspeccion>();

            using (Model1 context =
               new Model1())
            {
                var newEntidad = Mapper.Map<Inspeccion>(entidad);
                newEntidad.Fecha = DateTime.Now;
                context.Inspeccion.Add(newEntidad);
                context.SaveChanges();
                id = newEntidad.IdInspeccion;
            }
            return id;
        }

    }
}
