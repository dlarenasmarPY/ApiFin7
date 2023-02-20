using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTAgrupaDocumento
{
    public short TdoAgrupaCod { get; set; }

    public string TdoAgrupaGlosa { get; set; } = null!;

    public short UblCodigo { get; set; }
}
