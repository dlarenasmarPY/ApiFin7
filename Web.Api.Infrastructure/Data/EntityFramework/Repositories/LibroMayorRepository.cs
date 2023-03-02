using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequest.LibroMayor;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Infrastructure.Data.EntityFramework.Entities;

namespace Web.Api.Infrastructure.Data.EntityFramework.Repositories
{
    public class LibroMayorRepository : ILibroMayorRepository
    {
        protected readonly IConfiguration _configuration;
        public LibroMayorRepository(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        public async Task<List<LibroMayor>> GetLibroMayor(LibroMayorRequest request)
        {
            Fin700Context context = new Fin700Context(_configuration);
            try
            {
                return await Task.FromResult((from a in context.ConTCabeceraComs
                                              join b in context.ConTDetalleComs on a.CabCompId equals b.PCabCompId
                                              join c in context.ConTCuentas on b.PCtaId equals c.CtaId
                                              join d in context.GlbTPeriodos on new { a.PEmpId, a.PerId } equals new { d.PEmpId, d.PerId }
                                              join e in context.GlbTEmpresas on a.PEmpId equals e.EmpId
                                              join f in context.GlbTEntidads on e.PEntId equals f.EntId
                                              join g in context.GlbTMonedas on b.PMonedaId equals g.MonedaId
                                              join h in context.ConTTipoComprobantes on new { a.PEmpId, a.TcoId } equals new { h.PEmpId, h.TcoId }
                                              where d.EjeAno == request.anio && request.periodomes.Contains(d.PerMes) && a.ComEstadoCod == request.comEstado && d.PEmpId == (decimal)request.empresa
                                              select new LibroMayor
                                              {
                                                  empId = a.PEmpId,
                                                  razonEmpresa = f.EntRazonSocial,
                                                  periodo = a.PerId,
                                                  periodoGlosa = d.PerGlosa,
                                                  codComprobante = h.TcoId,
                                                  gloComprobante = h.TcoGlosa,
                                                  nroComprobante = a.ComNumero,
                                                  fechaComprobante = a.ComFecha,
                                                  glosaCentralizacion = a.ComGlosa,
                                                  linea = b.ComLinea,
                                                  cuenta = c.CtaCodigo,
                                                  gloCuenta = c.CtaNombre,
                                                  codMoneda = g.MonedaId,
                                                  gloMoneda = g.MonGlosa,
                                                  debeImpu = b.MovCceMontoImpuDebe,
                                                  haberImpu = b.MovCceMontoImpuHaber,
                                                  debeLocal = b.MovCceMontoLocalDebe,
                                                  haberLocal = b.MovCceMontoLocalHaber,
                                                  debeFunci = b.MovCceMontoConvDebe,
                                                  haberFunci = b.MovCceMontoConvHaber,
                                                  UserDig = a.DigUsuario,
                                                  codCcosto = ((context.ConTCentrosResps.Where((ConTCentrosResp c) => c.CreId == b.PCreId).FirstOrDefault() != null) ? context.ConTCentrosResps.Where((ConTCentrosResp c) => c.CreId == b.PCreId).FirstOrDefault().CreCodigo : 0),
                                                  gloCcosto = ((context.ConTCentrosResps.Where((ConTCentrosResp c) => c.CreId == b.PCreId).FirstOrDefault() != null) ? context.ConTCentrosResps.Where((ConTCentrosResp c) => c.CreId == b.PCreId).FirstOrDefault().CreNombre : string.Empty)
                                              }).ToList());
            }
            finally
            {
                if (context != null)
                {
                    ((IDisposable)context).Dispose();
                }
            }
        }

        private static KeyValuePair<int, string> getCreInfo(decimal pcreid, IConfiguration _configuration)
        {
            using Fin700Context context = new Fin700Context(_configuration);
            ConTCentrosResp result = context.ConTCentrosResps.Where((ConTCentrosResp c) => c.CreId == pcreid).FirstOrDefault();
            if (result == null)
            {
                return new KeyValuePair<int, string>(0, string.Empty);
            }
            return new KeyValuePair<int, string>(result.CreCodigo, result.CreNombre);
        }
    }
}
