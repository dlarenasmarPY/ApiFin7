using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTConfiguracion
{
    public decimal CfgCtaIdInter { get; set; }

    public decimal CfgCtaIdInterFlujo { get; set; }

    public short CfgConMaxRegistros { get; set; }

    public string EmpUid { get; set; } = null!;

    public string EmpPwd { get; set; } = null!;

    public int X1 { get; set; }

    public int X2 { get; set; }

    public byte PlanComun { get; set; }

    public decimal PMonedaPaisId { get; set; }

    public byte CfgUsaVentaTercero { get; set; }

    public byte IndEmpEmpDiv { get; set; }

    public byte CfgVtaUsaEspecificoUnico { get; set; }

    public double CfgMinTiempoSeg { get; set; }

    public double CfgMaxTiempoSeg { get; set; }

    public double CfgTiempoHh { get; set; }

    public decimal PPdcId { get; set; }

    public byte PdcNivel { get; set; }

    public string CfgPathArchivosFisicos { get; set; } = null!;

    public short CfgDiasAtrasoDte { get; set; }

    public string CfgGlosaMailDte { get; set; } = null!;

    public string CfgMailDte { get; set; } = null!;

    public decimal PEntReceptorId { get; set; }
}
