using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTDetalleCom
{
    public decimal DetCompId { get; set; }

    public decimal PCabCompId { get; set; }

    public int ComLinea { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PMonedaId { get; set; }

    public string ComGlosa { get; set; } = null!;

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public double MovCceMontoConvDebe { get; set; }

    public double MovCceMontoConvHaber { get; set; }
}
