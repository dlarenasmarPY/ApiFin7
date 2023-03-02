using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequest.SmartSheet;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Infrastructure.Data.EntityFramework.Entities;

namespace Web.Api.Infrastructure.Data.EntityFramework.Repositories
{
    public class SmartSheetRepository: ISmartSheetRepository
    {
        protected readonly IConfiguration _configuration;

        public SmartSheetRepository(IConfiguration configuration)
        {
           _configuration= 
                configuration;
        }
        public async Task<List<SmartSheetComisiones>> getDataComisiones(SmartSheetComisionesRequest request)
        {
            var fechaDefault = DateTime.Parse("1900-01-01 00:00:00.000");
            using (var context = new Fin700Context(_configuration))
            {
                var query = (from a in context.InmTCartaOferta
                             join b in context.GlbTEntidads on a.PEntId equals b.EntId
                             join c in context.InmTProyectos on a.PTprId equals c.PTprId
                             join d in context.ConTCentrosResps on c.PCreId equals d.CreId
                             join e in context.GlbTEmpresas on  a.PEmpId  equals  e.EmpId
                             join f in context.GlbTEntidads on e.PEntId equals f.EntId
                             join g in context.InmTInmuebleProyectos on new { a.PTprId,a.PryNumero } equals new { g.PTprId,g.PryNumero }
                             join h in context.InmTEstados on a.DocEstado equals h.DocEstado
                             join i in context.GlbTTiposProyectos on a.PTprId equals i.TprId
                             where h.TipoEstado == 2 && (a.FechaPromesa > request.FechaDesde && a.FechaPromesa < request.FechaHasta)
                             && d.CreCodigo.ToString().Substring(0,2) == request.Zona.ToString()
                             select new SmartSheetComisiones
                             { 
                                PtprId = a.PTprId.ToString(),
                                EntNomFantasia = f.EntNomFantasia,
                                CreNombre = d.CreNombre,
                                InmuebleCodigo = g.InmuebleCodigo,
                                CreCodigo = d.CreCodigo.ToString(),
                                Zona = getZona(d.CreCodigo.ToString()),
                                EntRut = b.EntRut,
                                EntRazonSocial = b.EntRazonSocial,
                                PrecioVentaInm = a.PrecioVentaInm.ToString(),
                                CarOfeNumInterno = a.CarOfeNumInterno.ToString(),
                                CarOfeFecha = a.CarOfeFecha.ToShortDateString(),
                                FechaPromesa = a.FechaPromesa.ToShortDateString(),
                                EstadoActual = h.Descripcion,
                                TprGlosa = i.TprGlosa,
                                Migrado = (from x in context.InmTCartaOferta
                                           join y in context.InmTInmuebleProyectos on new {x.PTprId,x.PryNumero } equals new {y.PTprId,y.PryNumero }
                                           join z in context.GlbTEntidads on x.PEntId equals z.EntId
                                           where x.PEntId == a.PEntId && x.PTprId != a.PTprId && x.FechaPromesa < a.FechaPromesa && x.FechaPromesa != fechaDefault
                                           select x).Any() ? "SI":"NO"
                             });

                return await query.ToListAsync();
            }
        
        }

        private static string getZona(string creCodigo)
        {
            var codigo = int.Parse(creCodigo.Substring(0, 2));
            switch (codigo)
            {
                case 23: return "Central";
                case 24: return "Norte";
                case 25: return "Sur";
                default:return string.Empty;
            }

        }
    }
}
