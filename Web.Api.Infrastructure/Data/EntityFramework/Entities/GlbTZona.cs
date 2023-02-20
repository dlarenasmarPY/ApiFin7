using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTZona
{
    public decimal ZonaId { get; set; }

    public string ZonaDescripcion { get; set; } = null!;
}
