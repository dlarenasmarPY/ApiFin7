using Azure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Dto.UseCaseRequest;
using Web.Api.Core.Interfaces.Gateways.Repositories;
using Web.Api.Infrastructure.Data.EntityFramework.Entities;

namespace Web.Api.Infrastructure.Data.EntityFramework.Repositories
{
    public class ForPayRepository : IForPayRepository
    {
        public async Task<List<CuotaPromesa>> GetCuotasPromesa(ForPayRequest request)
        {
            DateTime hoy = DateTime.Parse(DateTime.Now.ToShortDateString());
            int[] arrItem = new int[2] { 11, 19 };
            Fin700Context context = new Fin700Context();
            try
            {
                return await Task.FromResult((from a in context.InmTCartaOferta
                                              join b in context.InmTCarOfeDetItemFinans on a.CartaOfertaId equals b.PCartaOfertaId
                                              join c in context.InmTItemFinanciamientos on b.ItemFinId equals c.ItemFinId
                                              join d in context.GlbTEmpresas on a.PEmpId equals d.EmpId
                                              join e in context.GlbTEntidads on d.PEntId equals e.EntId
                                              join f in context.GlbTEntidads on a.PEntId equals f.EntId
                                              join g in context.GlbTValorDiarios on hoy equals g.MonVdmFec
                                              join h in context.GlbTTiposProyectos on a.PTprId equals h.TprId
                                              join i in context.InmTProyectos on a.PTprId equals i.PTprId
                                              where arrItem.Contains(b.ItemFinId) && a.DocEstado == 4 && (string.IsNullOrEmpty(request.rut) || f.EntRut.ToUpper().Contains(request.rut.ToUpper())) && (string.IsNullOrEmpty(request.empresa) || e.EntRazonSocial.ToUpper().Contains(request.empresa.ToUpper())) && (string.IsNullOrEmpty(request.proyecto) || h.TprGlosa.ToUpper().Contains(request.proyecto.ToUpper())) && !context.InmTPagosCartaOferta.Where((InmTPagosCartaOfertum c) => c.PCartaOfertaId == b.PCartaOfertaId && c.ItemFinId == b.ItemFinId && c.MovDocCuota == b.MovDocCuota).Any()
                                              group new { a, b, c, d, e, f, g, h } by new
                                              {
                                                  Nombre = f.EntRazonSocial,
                                                  Proyecto = h.TprGlosa,
                                                  PTprId = a.PTprId,
                                                  PryNumero = a.PryNumero,
                                                  Empresa = e.EntRazonSocial,
                                                  CarOfeNumInterno = a.CarOfeNumInterno,
                                                  ItemFinId = c.ItemFinId,
                                                  ItemFinGlosa = c.ItemFinGlosa,
                                                  FechaVenc = b.FechaVenc,
                                                  MovDocCuota = b.MovDocCuota,
                                                  MontoItem = b.MontoItem,
                                                  MonVdmValor1 = g.MonVdmValor1,
                                                  EntRut = f.EntRut,
                                                  PEmpId = a.PEmpId,
                                                  CarOfeFecha = a.CarOfeFecha,
                                                  CartaOfertaId = a.CartaOfertaId,
                                                  CmuCodigo = i.CmuCodigo,
                                                  PCotizacionId = a.PCotizacionId
                                              } into grp
                                              select new CuotaPromesa
                                              {
                                                  inmueble = context.InmTInmuebleProyectos.Where((InmTInmuebleProyecto i) => i.PTprId == grp.Key.PTprId && i.PryNumero == grp.Key.PryNumero).FirstOrDefault().InmuebleCodigo,
                                                  IdCliente = $"{grp.Key.PEmpId.ToString()}{grp.Key.CartaOfertaId.ToString()}",
                                                  Empresa = grp.Key.Empresa,
                                                  Proyecto = grp.Key.Proyecto,
                                                  PtprId = grp.Key.PTprId,
                                                  PryNumero = grp.Key.PryNumero,
                                                  Nombre = grp.Key.Nombre,
                                                  CartaOferta = grp.Key.CarOfeNumInterno,
                                                  Descripcion = grp.Key.ItemFinGlosa,
                                                  Vencimiento = grp.Key.FechaVenc.ToString("yyyy-MM-dd"),
                                                  Cuota = grp.Key.MovDocCuota,
                                                  Monto = grp.Key.MontoItem,
                                                  Rut = grp.Key.EntRut,
                                                  Zona = getZona(grp.Key.CmuCodigo),
                                                  IdentificadorCuota = $"{grp.Key.PCotizacionId}{grp.Key.MovDocCuota}",
                                                  mesAnio = $"{grp.Key.FechaVenc.Year}{grp.Key.FechaVenc.Month}"
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

        public async Task<List<ClientePromesaDto>> GetClientesPromesa()
        {
            DateTime hoy = DateTime.Parse(DateTime.Now.ToShortDateString());
            int[] arrItem = new int[2] { 11, 19 };
            Fin700Context context = new Fin700Context();
            try
            {
                return await Task.FromResult((from a in context.InmTCartaOferta
                                              join b in context.InmTCarOfeDetItemFinans on a.CartaOfertaId equals b.PCartaOfertaId
                                              join c in context.InmTItemFinanciamientos on b.ItemFinId equals c.ItemFinId
                                              join d in context.GlbTEmpresas on a.PEmpId equals d.EmpId
                                              join e in context.GlbTEntidads on d.PEntId equals e.EntId
                                              join f in context.GlbTEntidads on a.PEntId equals f.EntId
                                              join g in context.GlbTValorDiarios on hoy equals g.MonVdmFec
                                              join h in context.GlbTTiposProyectos on a.PTprId equals h.TprId
                                              join j in context.InmTHojaAntecedentes on a.PEntId equals j.PEntId
                                              join k in context.GlbTComunas on j.CmuCodigoTitular equals k.CmuCodigo
                                              join l in context.GlbTRegiones on k.RegCodigo equals l.RegCodigo
                                              where arrItem.Contains(b.ItemFinId) && a.DocEstado == 4 && !context.InmTPagosCartaOferta.Where((InmTPagosCartaOfertum c) => c.PCartaOfertaId == b.PCartaOfertaId && c.ItemFinId == b.ItemFinId && c.MovDocCuota == b.MovDocCuota).Any()
                                              group new { a, b, c, d, e, f, g, h } by new
                                              {
                                                  Nombre = f.EntRazonSocial,
                                                  Proyecto = h.TprGlosa,
                                                  PTprId = a.PTprId,
                                                  PryNumero = a.PryNumero,
                                                  Empresa = e.EntRazonSocial,
                                                  CarOfeNumInterno = a.CarOfeNumInterno,
                                                  ItemFinId = c.ItemFinId,
                                                  ItemFinGlosa = c.ItemFinGlosa,
                                                  EntRut = f.EntRut,
                                                  PEmpId = a.PEmpId,
                                                  CarOfeFecha = a.CarOfeFecha,
                                                  CartaOfertaId = a.CartaOfertaId,
                                                  rutEmpresa = e.EntRut,
                                                  DireccionTitular = j.DireccionTitular,
                                                  CmuCiudadTitular = j.CmuCiudadTitular,
                                                  TelefonoTitular = j.TelefonoTitular,
                                                  CmuNombre = k.CmuNombre,
                                                  EmailTitular = j.EmailTitular,
                                                  RegNombre = l.RegNombre,
                                                  FechaNacTitular = j.FechaNacTitular
                                              } into grp
                                              select new ClientePromesaDto
                                              {
                                                  inmueble = context.InmTInmuebleProyectos.Where((InmTInmuebleProyecto i) => i.PTprId == grp.Key.PTprId && i.PryNumero == grp.Key.PryNumero).FirstOrDefault().InmuebleCodigo,
                                                  IdCliente = $"{grp.Key.PEmpId.ToString()}{grp.Key.CartaOfertaId.ToString()}",
                                                  Empresa = grp.Key.Empresa,
                                                  Proyecto = grp.Key.Proyecto,
                                                  PtprId = grp.Key.PTprId,
                                                  PryNumero = grp.Key.PryNumero,
                                                  Nombre = grp.Key.Nombre,
                                                  CartaOferta = grp.Key.CarOfeNumInterno,
                                                  RutEmpresa = grp.Key.rutEmpresa,
                                                  Descripcion = grp.Key.ItemFinGlosa,
                                                  Rut = grp.Key.EntRut,
                                                  Celular = grp.Key.TelefonoTitular,
                                                  Ciudad = grp.Key.CmuCiudadTitular,
                                                  Correo = grp.Key.EmailTitular,
                                                  Direccion = grp.Key.DireccionTitular,
                                                  Region = grp.Key.RegNombre,
                                                  Comuna = grp.Key.CmuNombre,
                                                  FechaNacimiento = grp.Key.FechaNacTitular,
                                                  Cuotas = GetCuota(grp.Key.CartaOfertaId)
                                              }).AsParallel().ToList());
            }
            finally
            {
                if (context != null)
                {
                    ((IDisposable)context).Dispose();
                }
            }
        }

        private static string getZona(int idComuna)
        {
            using Fin700Context context = new Fin700Context();
            DbSet<GlbTComuna> glbTComunas = context.GlbTComunas;
            ParameterExpression parameterExpression = Expression.Parameter(typeof(GlbTComuna), "g");
            switch (idComuna)
		{
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 16:
			return "Zona Norte";
		case 6:
		case 7:
		case 13:
		case 15:
			return "Zona Centro";
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
			return "Zona sur";
                default:
			return "sin zona";
            }
        }

        private static List<Cuotas> GetCuota(decimal carofeid)
        {
            DateTime.Parse(DateTime.Now.ToShortDateString());
            _ = new int[2] { 11, 19 };
            using Fin700Context context = new Fin700Context();
            return (from a in context.InmTCartaOferta
                    join b in context.InmTCarOfeDetItemFinans on a.CartaOfertaId equals b.PCartaOfertaId
                    join c in context.InmTItemFinanciamientos on b.ItemFinId equals c.ItemFinId
                    join d in context.InmTPagosCartaOferta on new
                    {
                        l1 = a.CartaOfertaId,
                        l2 = b.ItemFinId,
                        l3 = b.MovDocCuota
                    } equals new
                    {
                        l1 = d.PCartaOfertaId,
                        l2 = d.ItemFinId,
                        l3 = d.MovDocCuota
                    } into lft
                    from dl in lft.DefaultIfEmpty()
                    where (decimal?)dl.PCabOpeId == null && a.CartaOfertaId == carofeid
                    select new Cuotas
                    {
                        NumeroCuota = b.MovDocCuota,
                        MontoCuota = b.MontoItem,
                        FechaVencimiento = b.FechaVenc.ToString("yyyy-MM-dd")
                    }).AsParallel().ToList();
        }

    }
}
