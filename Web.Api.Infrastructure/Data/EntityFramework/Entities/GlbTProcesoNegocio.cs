using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTProcesoNegocio
{
    public decimal ProNegocioId { get; set; }

    public short ProNegocioCod { get; set; }

    public string ProNegocioGlosa { get; set; } = null!;

    public byte TcoTipoFuncion { get; set; }
}
