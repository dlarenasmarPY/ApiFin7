using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTTipoEnvio
{
    public short TipoEnvioId { get; set; }

    public string TipoEnvioGlosa { get; set; } = null!;
}
