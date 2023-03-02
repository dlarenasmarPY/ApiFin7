using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequest;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Infrastructure.Data.EntityFramework.Entities;

namespace Web.Api.Infrastructure.Data.EntityFramework.Repositories
{
    public class CuentasPorPagarRepository : ICuentasPorPagarRepository
    {
        protected readonly IConfiguration _configuration;
        public CuentasPorPagarRepository(IConfiguration configuration)
        {
            _configuration= configuration;
        }
        public async Task<List<BalanceCuentasPagarCentroCosto>> GetBalanceCuentasPagarCentroCostos(balanceCuentasPorPagarRequest request)
        {
            List<BalanceCuentasPagarCentroCosto> pagarCentroCostos;
            using (Fin700Context context = new Fin700Context(_configuration))
            {
                return await Task.FromResult((from mov in context.CceTMovimientos
                                              join cta in context.ConTCuentas on mov.PCtaId equals cta.CtaId
                                              join per in context.GlbTPeriodos on new { mov.PEmpId, mov.PerId } equals new { per.PEmpId, per.PerId }
                                              join emp in context.GlbTEmpresas on mov.PEmpId equals emp.EmpId
                                              join ent in context.GlbTEntidads on emp.PEntId equals ent.EntId
                                              join doc in context.CceTDocumentos on mov.PDocCceId equals doc.DocCceId
                                              join mon in context.GlbTMonedas on doc.PMonedaId equals mon.MonedaId
                                              join pro in context.GlbTEntidads on doc.PEntId equals pro.EntId
                                              join dct in context.GlbTDocumentos on doc.TdoId equals dct.TdoId
                                              join prm in context.GlbTPeriodos on per.PEmpId equals prm.PEmpId
                                              join ccost in context.ConTCentrosResps on mov.PCreId equals ccost.CreId into ConCentros
                                              from pccost in ConCentros.DefaultIfEmpty()
                                              where prm.EjeAno == request.Periodo.Year && prm.PerMes == request.Periodo.Month && (mov.MovCceConNumero == 0 || (mov.MovCceConNumero > 0 && mov.MovCceConFecha > request.Periodo)) && cta.CtaCodigo >= request.CuentaInicio && cta.CtaCodigo <= request.CuentaFin && cta.TauId == 9 && doc.PMonedaId == 1m && mov.MovCceMontoImpuDebe - mov.MovCceMontoImpuHaber != 0.0 && per.PerId <= prm.PerId
                                              group new { mov, ent, pro, cta, dct, doc, mon, pccost } by new
                                              {
                                                  mov.MovCceNumCuota,
                                                  mov.PEmpId,
                                                  ent.EntNomFantasia,
                                                  pro.EntRut,
                                                  pro.EntRazonSocial,
                                                  cta.CtaCodigo,
                                                  cta.CtaNombre,
                                                  dct.TdoId,
                                                  dct.TdoGlosa,
                                                  doc.DocCceNumero,
                                                  mon.MonedaId,
                                                  mon.MonGlosa,
                                                  pccost.CreCodigo,
                                                  pccost.CreNombre,
                                                  doc.PMonedaId
                                              } into g
                                              select new BalanceCuentasPagarCentroCosto
                                              {
                                                  EmpId = g.Key.PEmpId,
                                                  Empresa = g.Key.EntNomFantasia,
                                                  Rut = g.Key.EntRut,
                                                  Cliente = g.Key.EntRazonSocial,
                                                  Cuenta = g.Key.CtaCodigo,
                                                  NomCuenta = g.Key.CtaNombre,
                                                  CCosto = g.Key.CreCodigo,
                                                  NomCCosto = g.Key.CreNombre,
                                                  Cod_Moneda = g.Key.PMonedaId,
                                                  Contable = g.Max(d => d.doc.DocCceFecEmi),
                                                  Cod_documento = g.Key.TdoId,
                                                  Glo_Documento = g.Key.TdoGlosa,
                                                  Documento = g.Key.DocCceNumero,
                                                  nro_cuota = g.Key.MovCceNumCuota,
                                                  CodMoneda = g.Key.MonedaId,
                                                  GloMoneda = g.Key.MonGlosa,
                                                  Vencimiento = g.Max(d => d.mov.MovCceFecVenc),
                                                  debe_impu = g.Sum(d => d.mov.MovCceMontoImpuDebe),
                                                  haber_impu = g.Sum(d => d.mov.MovCceMontoImpuHaber),
                                                  saldo_input = g.Sum(d => d.mov.MovCceMontoImpuDebe) - g.Sum(d => d.mov.MovCceMontoImpuHaber),
                                                  debe_local = g.Sum(d => d.mov.MovCceMontoLocalDebe),
                                                  haber_local = g.Sum(d => d.mov.MovCceMontoLocalHaber),
                                                  saldo_pesos = g.Sum(d => d.mov.MovCceMontoLocalDebe) - g.Sum(d => d.mov.MovCceMontoLocalHaber)
                                              }).AsParallel().ToList());
            }
        }

        public async Task<List<BalanceCuentasPagarCentroCostoProvision>> getBalanceProvision(BalanceCuentasPorPagarCentroCostoProvisionRequest request)
        {
            using Fin700Context context = new Fin700Context(_configuration);
            return await Task.FromResult((from mov in context.CceTMovimientos
                                          join cta in context.ConTCuentas on mov.PCtaId equals cta.CtaId
                                          join per in context.GlbTPeriodos on new { mov.PerId, mov.PEmpId } equals new { per.PerId, per.PEmpId }
                                          join emp in context.GlbTEmpresas on mov.PEmpId equals emp.EmpId
                                          join ent in context.GlbTEntidads on emp.PEntId equals ent.EntId
                                          join doc in context.CceTDocumentos on mov.PDocCceId equals doc.DocCceId
                                          join pro in context.GlbTEntidads on doc.PEntId equals pro.EntId
                                          join dct in context.GlbTDocumentos on doc.TdoId equals dct.TdoId
                                          join ccost in context.ConTCentrosResps on mov.PCreId equals ccost.CreId
                                          join mon in context.GlbTMonedas on doc.PMonedaId equals mon.MonedaId
                                          where (decimal?)mov.PEmpId == (decimal?)request.Empresa && (int?)cta.CtaCodigo >= request.CtaCodigo1 && (int?)cta.CtaCodigo <= request.CtaCodigo2 && (int?)mov.PerId == request.Periodo + (int?)1 && mov.SisCodOri == 10 && cta.TauId == 9 && doc.PMonedaId == 1m
                                          select new BalanceCuentasPagarCentroCostoProvision
                                          {
                                              EmpId = mov.PEmpId,
                                              Empresa = ent.EntNomFantasia,
                                              Rut = pro.EntRut,
                                              Cliente = pro.EntRazonSocial,
                                              Cuenta = cta.CtaCodigo,
                                              NomCuenta = cta.CtaNombre,
                                              CCosto = ccost.CreCodigo,
                                              NomCCosto = ccost.CreNombre,
                                              CodMoneda = doc.PMonedaId,
                                              Vencimiento = mov.MovCceFecVenc,
                                              Contable = doc.DocCceFecEmi,
                                              CodDocumento = dct.TdoId,
                                              GloDocumento = dct.TdoGlosa,
                                              Documento = doc.DocCceNumero,
                                              nroCuota = mov.MovCceNumCuota,
                                              GloMoneda = mon.MonGlosa,
                                              DebeImpu = mov.MovCceMontoImpuDebe,
                                              HaberImpu = mov.MovCceMontoImpuHaber,
                                              SaldoImpu = mov.MovCceMontoImpuDebe - mov.MovCceMontoImpuHaber,
                                              DebeLocal = mov.MovCceMontoLocalDebe,
                                              HaberLocal = mov.MovCceMontoLocalHaber,
                                              SaldoPesos = mov.MovCceMontoLocalDebe - mov.MovCceMontoLocalHaber
                                          }).AsParallel().ToList());
        }
    }
}
