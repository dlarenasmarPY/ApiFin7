using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneAuditorium
{
    public long Numrep { get; set; }

    public long Numaud { get; set; }

    public long? Numusu { get; set; }

    public string? Fecaud { get; set; }

    public string? Tipaud { get; set; }

    public string? Corenv { get; set; }

    public long? Numpro { get; set; }

    public string? Sensql { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }

    public string? Ipaddr { get; set; }

    public long? Baseje { get; set; }
}
