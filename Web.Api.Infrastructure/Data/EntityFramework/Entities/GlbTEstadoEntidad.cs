using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEstadoEntidad
{
    public byte EstEntCod { get; set; }

    public string EstEntGlosa { get; set; } = null!;
}
