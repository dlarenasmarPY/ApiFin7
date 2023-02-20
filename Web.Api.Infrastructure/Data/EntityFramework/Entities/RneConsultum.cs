using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneConsultum
{
    public long Numrep { get; set; }

    public long Numcon { get; set; }

    public string? Nomcon { get; set; }

    public string? Sensql { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
