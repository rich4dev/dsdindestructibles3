using AutoMapper;
using DSDIndestructibles3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSDIndestructibles3.Datos
{
    public class SolicitudServicioData
    {
        public void Add(SolicitudServicioBE entidad)
        {
            Mapper.CreateMap<SolicitudServicioBE, SolicitudServicio>();

            using (indestructibles3Entities context =
               new indestructibles3Entities())
            {
                var newEntidad = Mapper.Map<SolicitudServicio>(entidad);
                context.SolicitudServicio.Add(newEntidad);
            }
        }
        public void Update(SolicitudServicioBE entidad)
        {
            Mapper.CreateMap<SolicitudServicioBE, SolicitudServicio>();

            using (indestructibles3Entities context =
               new indestructibles3Entities())
            {
                var newEntidad = Mapper.Map<SolicitudServicio>(entidad);
                context.SolicitudServicio.Find(entidad.SolicitudServicioId);
                context.SolicitudServicio.Attach(newEntidad);
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (indestructibles3Entities context =
               new indestructibles3Entities())
            {
                var newEntidad = context.SolicitudServicio.Find(id);
                context.SolicitudServicio.Remove(newEntidad);
                context.SaveChanges();
            }
        }
    }
}
