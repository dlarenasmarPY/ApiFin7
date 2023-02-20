using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTTipoFactura
{
    public byte TipFactId { get; set; }

    public string TipFactGlosa { get; set; } = null!;
}
