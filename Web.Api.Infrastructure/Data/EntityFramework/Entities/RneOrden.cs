using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneOrden
{
    public long Numrep { get; set; }

    public long Numcol { get; set; }

    public string? Tipord { get; set; }

    public double? Ordcol { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
