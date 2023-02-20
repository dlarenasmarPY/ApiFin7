using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemInfCompara
{
    public string CodOwner { get; set; } = null!;

    public string PrRdescripcion { get; set; } = null!;

    public decimal PConcRemId { get; set; }

    public string CnRtipoFormula { get; set; } = null!;

    public string CnRcodigo { get; set; } = null!;

    public string CnRdescripcion { get; set; } = null!;

    public string ColColumna { get; set; } = null!;

    public string Coldescripcion { get; set; } = null!;

    public string CodigoCorte { get; set; } = null!;

    public string DescripCorte { get; set; } = null!;

    public double LqDvalor { get; set; }

    public double LqTmontoLiquido { get; set; }

    public short LqdPersonas { get; set; }

    public string PerGlosa { get; set; } = null!;

    public double LqDvalorAnt { get; set; }

    public short LqdPersonasAnt { get; set; }

    public double LqTmontoLiquidoAnt { get; set; }

    public string XPerGlosa { get; set; } = null!;

    public decimal PCtoId { get; set; }
}
