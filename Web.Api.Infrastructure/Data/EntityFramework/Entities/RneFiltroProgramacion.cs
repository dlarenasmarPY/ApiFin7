using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneFiltroProgramacion
{
    public long Numrep { get; set; }

    public long Numfil { get; set; }

    public long Numpro { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
