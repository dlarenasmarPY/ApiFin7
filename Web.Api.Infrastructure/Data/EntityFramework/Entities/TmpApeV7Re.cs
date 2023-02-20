using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpApeV7Re
{
    public int? Empid { get; set; }

    public int? Perid { get; set; }

    public int? Permes { get; set; }

    public int? PCabCompId { get; set; }

    public int ComLinea { get; set; }

    public int? DivCodigo { get; set; }

    public int? PCtaId { get; set; }

    public int? PCreId { get; set; }

    public int? PMonedaId { get; set; }

    public string? ComGlosa { get; set; }

    public decimal? MovCceMontoImpuDebe { get; set; }

    public decimal? MovCceMontoImpuHaber { get; set; }

    public decimal? MovCceMontoLocalDebe { get; set; }

    public decimal? MovCceMontoLocalHaber { get; set; }

    public decimal? MovCceMontoConvDebe { get; set; }

    public decimal? MovCceMontoConvHaber { get; set; }
}
