using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoMonedaCnci
{
    public short TipoMonedaCnci { get; set; }

    public string MonedaGlosaCnci { get; set; } = null!;

    public string MonedaGlosaAduana { get; set; } = null!;
}
