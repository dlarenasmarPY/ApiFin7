using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequest.BancoEstado;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Infrastructure.Data.EntityFramework.Entities;

namespace Web.Api.Infrastructure.Data.EntityFramework.Repositories
{
    public class BancoEstadoRepository : IBancoEstadoRepository
    {
        protected readonly IConfiguration _configuration;

        public BancoEstadoRepository(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        public async Task<List<PlantillaBancoEstado>> getPlantillaBancoEstado(PlantillaBancoEstadoRequest request)
        {
            List<PlantillaBancoEstado> plantillaBancoEstado;
            using (Fin700Context context = new Fin700Context(_configuration))
            {

                var query = from a in context.CceTMovimientos
                            join b in context.CceTDocumentos on a.PDocCceId equals b.DocCceId
                            join c in context.GlbTEntidads on b.PEntId equals c.EntId
                            join d in context.GlbTEmpresas on b.PEmpId equals d.EmpId
                            join e in context.GlbTEntidads on d.PEntId equals e.EntId
                            join f in context.GlbTDocumentos on b.TdoId equals f.TdoId
                            join g in context.GlbTEntidads on a.PEntIdPago equals g.EntId
                            join h in context.GlbTEntidadSucursals on c.EntId equals h.PEntId
                            join i in context.ConTCuentas on a.PCtaId equals i.CtaId
                            join j in context.ConTCentrosResps on a.PCreId equals j.CreId
                            join k in context.GlbTFormaPagos on h.PFormaPagoId equals k.FormaPagoId
                            where h.EntSucNumero == 1 && a.PEmpId == (decimal)request.EmpId && a.MovCceFecPagoPropuesta >= request.Fecha && a.MovCceFecPagoPropuesta <= request.Fecha && a.MovCceDigUsuario == request.Usuario && a.MovCceEstado == request.Estado
                            orderby c.EntRut
                            select new PlantillaBancoEstado
                            {
                                Rut = getRut(c.EntRut),
                                RazonSocial = c.EntRazonSocial,
                                Correo = string.Empty,
                                Banco = ((h.EntSucCodCtaCteBco != string.Empty) ? getCodeBanco(h.InstCod) : "012"),
                                FormaPago = ((h.EntSucCodCtaCteBco != string.Empty) ? "01" : "23"),
                                NCuenta = ((h.EntSucCodCtaCteBco != string.Empty) ? h.EntSucCodCtaCteBco : "0"),
                                SectorFinanciero = "26",
                                MontoPago = ((a.MovCceMontoImpuDebe > 0.0) ? a.MovCceMontoImpuDebe : (a.MovCceMontoImpuHaber * -1.0)),
                                SucursalBech = "001"
                            };
                return await Task.FromResult((query.ToList()));
            }
        }

        private static string getCodeBanco(int instCod)
        {
            switch (instCod)
            {
                case 1:
                    return "001";
                case 9:
                    return "009";
                case 12:
                    return "012";
                case 14:
                    return "014";
                case 16:
                    return "016";
                case 27:
                    return "027";
                case 28:
                    return "028";
                case 29:
                    return "001";
                case 35:
                    return "037";
                case 37:
                    return "037";
                case 39:
                    return "039";
                case 49:
                    return "049";
                case 51:
                    return "051";
                case 504:
                    return "014";
                case 507:
                    return "014";
                case 735:
                    return "053";
                case 751:
                    return "055";
                default:
                    return "";
            }
        }

        private static string getRut(string rutCompleto)
        {
            string[] strArray = rutCompleto.Split("-");
            return string.Format("{0}{1}", (object)int.Parse(strArray[0]), (object)strArray[1]);
        }
    }
}
