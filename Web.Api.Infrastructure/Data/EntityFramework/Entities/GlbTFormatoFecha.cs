using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFormatoFecha
{
    public decimal FormatoFechaId { get; set; }

    public string FormatoFecha { get; set; } = null!;

    public string IndSeleccion { get; set; } = null!;
}
