using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoFlujo
{
    public decimal TipoFlujoCod { get; set; }

    public string TipoFlujoDescripcion { get; set; } = null!;

    public short TipoItems { get; set; }
}
