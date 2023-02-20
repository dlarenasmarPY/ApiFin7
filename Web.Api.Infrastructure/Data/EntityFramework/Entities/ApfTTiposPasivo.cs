using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTTiposPasivo
{
    public byte TipoPasivoId { get; set; }

    public string TipoPasivoGlosa { get; set; } = null!;
}
