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
    public class SolicitudServicioData
    {
        public void Add(SolicitudServicioDTO entidad)
        {
            Mapper.CreateMap<SolicitudServicioDTO, SolicitudServicio>();

            using (Model1 context =
               new Model1())
            {
                var newEntidad = Mapper.Map<SolicitudServicio>(entidad);
                context.SolicitudServicio.Add(newEntidad);
                context.SaveChanges();
            }
        }
        public void Update(SolicitudServicioDTO entidad)
        {
            Mapper.CreateMap<SolicitudServicioDTO, SolicitudServicio>();

            using (Model1 context =
               new Model1())
            {
                var entidadSearch = context.SolicitudServicio.Find(entidad.SolicitudServicioId);
                entidadSearch = Mapper.Map<SolicitudServicio>(entidad);
                context.Entry(entidadSearch).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            using (Model1 context =
               new Model1())
            {
                var newEntidad = context.SolicitudServicio.Find(id);
                context.SolicitudServicio.Remove(newEntidad);
                context.SaveChanges();
            }
        }
        public SolicitudServicioDTO Get(int id)
        {
            Mapper.CreateMap<SolicitudServicio, SolicitudServicioDTO>();
            var entidadDTO = new SolicitudServicioDTO();
            var entidadSearch = new SolicitudServicio();
            using (Model1 context =
               new Model1())
            {
                entidadSearch = context.SolicitudServicio.Find(id);
            }
            entidadDTO = Mapper.Map<SolicitudServicioDTO>(entidadSearch);

            return entidadDTO;
        }
        public List<SolicitudServicioDTO> GetBandeja(DateTime fechaDesde, DateTime fechaHasta, string estado, int empresaId)
        {
            var lista = new List<SolicitudServicioDTO>();
            var listaQuery = new object();
            using (Model1 context =
               new Model1())
            {
                var query = from s in context.SolicitudServicio
                        join c in context.Cliente on s.ComercioId equals c.ClienteId
                        where (c.FechaReg >= fechaDesde && c.FechaReg <= fechaHasta) && c.Estado == estado && s.EmpresaId == empresaId
                        select new SolicitudServicioDTO()
                                            {
                                                SolicitudServicioId = s.SolicitudServicioId,
                                                MotivoSolicitudId = (int)s.MotivoSolicitudId,
                                                ClienteRuc = c.Ruc,
                                                ClienteRazonSocial = c.RazonSocial,
                                                Estado = s.Estado
                                            };
                lista = query.ToList();

                //lista = context.SolicitudServicio
                //    .Where(x => (x.FechaReg >= fechaDesde && x.FechaReg <= fechaHasta) && x.Estado == estado && x.EmpresaId == empresaId)
                //    .Select(x => new SolicitudServicioDTO()
                //    {
                //        SolicitudServicioId = x.SolicitudServicioId,
                //        MotivoSolicitudId = (int)x.MotivoSolicitudId,
                //        Estado = x.Estado
                //    }).ToList();
            }
            return lista;
        }
    }
}
