using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneBaseReporte
{
    public long Numbas { get; set; }

    public long Numrep { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public long? Usuact { get; set; }
}
