using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoGasto
{
    public short TgasCodigo { get; set; }

    public string TgasNombre { get; set; } = null!;

    public decimal PCtaId { get; set; }
}
