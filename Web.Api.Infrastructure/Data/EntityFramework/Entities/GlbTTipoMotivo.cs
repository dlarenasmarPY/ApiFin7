using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoMotivo
{
    public short GlbTipoMotivo { get; set; }

    public string GlbTipoMotivoGlosa { get; set; } = null!;
}
