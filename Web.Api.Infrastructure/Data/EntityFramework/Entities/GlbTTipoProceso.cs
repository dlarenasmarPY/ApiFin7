using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoProceso
{
    public byte ProcesoCod { get; set; }

    public string ProcesoGlosa { get; set; } = null!;

    public byte ProcesoVigencia { get; set; }
}
