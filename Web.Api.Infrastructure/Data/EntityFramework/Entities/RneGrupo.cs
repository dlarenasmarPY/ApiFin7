using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneGrupo
{
    public long Numrep { get; set; }

    public long Numcol { get; set; }

    public double? Ordgru { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
