using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTActividadEco
{
    public int AecCod { get; set; }

    public string AecGlosa { get; set; } = null!;

    public string AecGlosa255 { get; set; } = null!;
}
