using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemInfPago
{
    public decimal InfPagId { get; set; }

    public string CodOwner { get; set; } = null!;

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public string EntRut { get; set; } = null!;

    public string FicEntRazonSocial { get; set; } = null!;

    public decimal CtoNumero { get; set; }

    public DateTime CtoFecVigencia { get; set; }

    public decimal PLiqId { get; set; }

    public string PrRdescripcion { get; set; } = null!;

    public string PerGlosa { get; set; } = null!;

    public short CgoCodCargo { get; set; }

    public string CgoNombre { get; set; } = null!;

    public int CreCodigo { get; set; }

    public string CreNombre { get; set; } = null!;

    public string PreIndPrevisional { get; set; } = null!;

    public decimal PAfpParId { get; set; }

    public string AfpRazonSocial { get; set; } = null!;

    public int AfpCodSuperInt { get; set; }

    public decimal PCjAparId { get; set; }

    public string CjArazonSocial { get; set; } = null!;

    public int CjAcodSuperInt { get; set; }

    public decimal PIsaParId { get; set; }

    public string IsaRazonSocial { get; set; } = null!;

    public int IsaCodSuperInt { get; set; }

    public decimal PLugId { get; set; }

    public short LugCodigo { get; set; }

    public string LugDescripcion { get; set; } = null!;

    public decimal PItmLugarPagoId { get; set; }

    public short LugPagItmCodigo { get; set; }

    public string LugPagItmDesc { get; set; } = null!;

    public decimal PItmIntegroId { get; set; }

    public short LugIntegroCod { get; set; }

    public string LugarIntegroGlosa { get; set; } = null!;

    public DateTime LiqFecPago { get; set; }

    public double LqTmontoLiquido { get; set; }

    public double IlgSueldoBase { get; set; }

    public double LqTtimponible { get; set; }

    public double LqTtimponTopeAcc { get; set; }

    public double LqTttributable { get; set; }

    public double LqTalcanceLiquido { get; set; }

    public double LqTotrosDesctos { get; set; }

    public double LqTtdescLegales { get; set; }

    public double LqTthaberes { get; set; }

    public double LqTtafectoImpto { get; set; }

    public double LqTtafectoImptoAcc { get; set; }

    public double LqTthaberesAcc { get; set; }

    public double LqTtprevPensionAcc { get; set; }

    public double LqTtprevSaludAcc { get; set; }

    public double LqTtprevSegCesAcc { get; set; }

    public double LqTtimpuestosAcc { get; set; }

    public double LqTdiasPago { get; set; }

    public int InstCod { get; set; }

    public short EntSucInstSuc { get; set; }

    public string EntSucCodCtaCteBco { get; set; } = null!;

    public double ConcHrExt { get; set; }

    public double ConcHrOrd { get; set; }

    public double ConcHrTur { get; set; }

    public double ConcVlDom { get; set; }
}
