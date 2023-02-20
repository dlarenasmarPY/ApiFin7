using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneValor
{
    public long Numrep { get; set; }

    public long Numfil { get; set; }

    public long Numval { get; set; }

    public double? Vinnum { get; set; }

    public double? Vtenum { get; set; }

    public string? Vintex { get; set; }

    public string? Vtetex { get; set; }

    public string? Vinfec { get; set; }

    public string? Vtefec { get; set; }

    public double? Numcol { get; set; }

    public string? Sensql { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }

    public long Numpro { get; set; }
}
