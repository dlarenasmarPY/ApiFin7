using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoVencimiento
{
    public short TvenCodigo { get; set; }

    public string TvenNombre { get; set; } = null!;

    public byte CantidadMeses { get; set; }
}
