using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemCalcConcCto
{
    public decimal TmpConcId { get; set; }

    public string CodOwner { get; set; } = null!;

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public decimal PCtoId { get; set; }

    public string CnRcodigo { get; set; } = null!;

    public int CnTprioridadCalc { get; set; }

    public string CnTorigenMov { get; set; } = null!;

    public decimal LqDorigenMov { get; set; }

    public decimal CnTrefOrigen { get; set; }

    public byte CnTindValorInf { get; set; }

    public decimal CnTmdaId { get; set; }

    public double CnTvalorNumerico { get; set; }

    public string? CnTvalorAlNum { get; set; }

    public DateTime? CnTvalorFecha { get; set; }

    public short? CnTvalorHora { get; set; }

    public double? CnTbaseNum { get; set; }

    public string? CnTbaseAlfNum { get; set; }

    public short? CntPerIdIniDev { get; set; }

    public int CnTanoMesIniDev { get; set; }

    public short? CntPerIdTerDev { get; set; }

    public int CnTanoMesTerDev { get; set; }

    public byte CnTindFormula { get; set; }

    public string CnTformula { get; set; } = null!;

    public double CnTvalorAplicado { get; set; }
}
