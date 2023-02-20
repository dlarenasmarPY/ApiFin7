using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFormatoCheque
{
    public byte TesFormatoCheque { get; set; }

    public string TesFormatoGlosa { get; set; } = null!;

    public decimal TesTipoFormato { get; set; }
}
