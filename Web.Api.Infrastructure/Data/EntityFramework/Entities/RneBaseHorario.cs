using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneBaseHorario
{
    public long Numbas { get; set; }

    public long Numhor { get; set; }

    public string? Deshor { get; set; }

    public string? Fecini { get; set; }

    public string? Fecter { get; set; }

    public string? Horini { get; set; }

    public string? Horter { get; set; }

    public string? Indblo { get; set; }

    public double? Coshor { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }
}
