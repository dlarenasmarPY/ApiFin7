using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneTabla
{
    public long Numrep { get; set; }

    public long Numtab { get; set; }

    public string? Nomtab { get; set; }

    public string? Idetab { get; set; }

    public double? Ordtab { get; set; }

    public string? Tiptab { get; set; }

    public string? Sensql { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
