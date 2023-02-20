using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTEstado
{
    public byte ConEstCod { get; set; }

    public string ConEstTipoEstado { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public string? ConEstGlosa { get; set; }

    public string ConEstGlosaCorta { get; set; } = null!;
}
