using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemLegalesAnt
{
    public decimal IlgAntId { get; set; }

    public string CodOwner { get; set; } = null!;

    public string InfRcodigo { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public string PerRut { get; set; } = null!;

    public decimal PLiqId { get; set; }

    public decimal PliqDetId { get; set; }

    public string FicEntRazonSocial { get; set; } = null!;

    public string IlgSexCodigo { get; set; } = null!;

    public DateTime FicFecNacimiento { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal CtoNumero { get; set; }

    public short CgoCodCargo { get; set; }

    public string CgoNombre { get; set; } = null!;

    public double CgoPorcentaje { get; set; }

    public decimal LqTperId { get; set; }

    public string PerGlosa { get; set; } = null!;

    public string PrRcodigo { get; set; } = null!;

    public string PrRdescripcion { get; set; } = null!;

    public int CreCodigo { get; set; }

    public string CreNombre { get; set; } = null!;

    public decimal PAfpParId { get; set; }

    public string AfpRazonSocial { get; set; } = null!;

    public decimal PAfcParId { get; set; }

    public string AfcRazonSocial { get; set; } = null!;

    public int AfpCodSuperInt { get; set; }

    public string RutEntidad { get; set; } = null!;

    public decimal PCjAparId { get; set; }

    public string CjArazonSocial { get; set; } = null!;

    public int CjAcodSuperInt { get; set; }

    public decimal PCjCparId { get; set; }

    public string CjCrazonSocial { get; set; } = null!;

    public int CjCcodSuperInt { get; set; }

    public decimal PIsaParId { get; set; }

    public string IsaRazonSocial { get; set; } = null!;

    public int IsaCodSuperInt { get; set; }

    public decimal PMutParId { get; set; }

    public string MutRazonSocial { get; set; } = null!;

    public decimal PMutualEntSucId { get; set; }

    public string MutSucDescripcion { get; set; } = null!;

    public string MutDirDireccion { get; set; } = null!;

    public string MutCmuNombre { get; set; } = null!;

    public int MutCodSuperInt { get; set; }

    public string PreIndPrevisional { get; set; } = null!;

    public decimal PreIndCotizacion { get; set; }

    public byte PreIndJubilado { get; set; }

    public decimal PItmIntegroId { get; set; }

    public short LugIntegroItmCodigo { get; set; }

    public string LugIntegroItmDesc { get; set; } = null!;

    public decimal PLugId { get; set; }

    public short LugCodigo { get; set; }

    public string LugDescripcion { get; set; } = null!;

    public decimal PItmLugarPagoId { get; set; }

    public short LugPagItmCodigo { get; set; }

    public string LugPagItmDesc { get; set; } = null!;

    public DateTime LiqFecPago { get; set; }

    public decimal PTramoIdNew { get; set; }

    public string TraCodTramo { get; set; } = null!;

    public string AfpFun { get; set; } = null!;

    public string SalFun { get; set; } = null!;

    public decimal SalPlan { get; set; }

    public decimal PTramoId { get; set; }

    public decimal PMonedaPlanId { get; set; }

    public decimal IlgSalPlan { get; set; }

    public double VinTasaImposicionCja { get; set; }

    public short VinCodExCajaCja { get; set; }

    public short VinCodRegimenAntCja { get; set; }

    public decimal VinComisionFijaAfp { get; set; }

    public double VinComisionSegAfp { get; set; }

    public double VinComisionMayorAfp { get; set; }

    public double IlgTasaAccidentes { get; set; }

    public double IlgTasaAdiAccidentes { get; set; }

    public double IlgSaludPorcentaje { get; set; }

    public int IlgSecDeclaracion { get; set; }
}
