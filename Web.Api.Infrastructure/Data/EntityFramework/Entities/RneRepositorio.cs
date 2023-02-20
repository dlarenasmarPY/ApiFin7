using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneRepositorio
{
    public long Numrpt { get; set; }

    public string? Desrpt { get; set; }

    public string? Virfil { get; set; }

    public string? Virbit { get; set; }

    public string? Fisfil { get; set; }

    public string? Fisbit { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
