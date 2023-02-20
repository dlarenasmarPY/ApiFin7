using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoItem
{
    public short TipoItems { get; set; }

    public string TipoGlosa { get; set; } = null!;

    public byte IndUsaCta { get; set; }
}
