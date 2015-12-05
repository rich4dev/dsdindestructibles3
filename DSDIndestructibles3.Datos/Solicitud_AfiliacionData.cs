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
    public class Solicitud_AfiliacionData
    {
        public Solicitud_AfiliacionDTO Get(int id)
        {
            Mapper.CreateMap<Solicitud_Afiliacion, Solicitud_AfiliacionDTO>();
            var entidadDTO = new Solicitud_AfiliacionDTO();
            var entidadSearch = new Solicitud_Afiliacion();
            using (Model1 context =
               new Model1())
            {
                entidadSearch = context.Solicitud_Afiliacion.Find(id);
            }
            entidadDTO = Mapper.Map<Solicitud_AfiliacionDTO>(entidadSearch);

            return entidadDTO;
        }
        public List<Solicitud_AfiliacionDTO> GetAllSolicitudAfiliaciones()
        {
            var lista = new List<Solicitud_AfiliacionDTO>();
            var listaQuery = new object();
            using (Model1 context =
               new Model1())
            {
                lista = context.Solicitud_Afiliacion
                    .Select(x => new Solicitud_AfiliacionDTO() {
                        SolicitudAfiliacionID = x.SolicitudAfiliacionID,
                        RUC = x.RUC,
                        RazonSocial = x.RazonSocial,
                        NombreComercial = x.NombreComercial,
                        DireccionComercial = x.DireccionComercial,
                        DireccionAdministrativa = x.DireccionAdministrativa,
                        RepresentanteLegal1 = x.RepresentanteLegal1,
                        RepresentanteLegal2 = x.RepresentanteLegal2,
                        PersonaContactoPuntoVenta = x.PersonaContactoPuntoVenta,
                        NumeroCuentaBancaria = x.NumeroCuentaBancaria,
                        TipoCuenta = x.TipoCuenta,
                        TipoMoneda = x.TipoMoneda,
                        EntidadFinanciera = x.EntidadFinanciera,
                        TipoAFiliacion = x.TipoAFiliacion,
                        TipoProduccto = x.TipoProduccto,
                        TipoComunicacion = x.TipoComunicacion,
                        FechaInstalacion = x.FechaInstalacion
                    }).ToList();
            }
            return lista;
        }
    }
}
