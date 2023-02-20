using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFormato
{
    public decimal FormatoId { get; set; }

    public string IndFormato { get; set; } = null!;

    public string FormatoGlosa { get; set; } = null!;
}
