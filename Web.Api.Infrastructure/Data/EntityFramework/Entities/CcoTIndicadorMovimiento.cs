using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTIndicadorMovimiento
{
    public byte TipMovCcoTipo { get; set; }

    public string IndMovCcoGlosa { get; set; } = null!;
}
