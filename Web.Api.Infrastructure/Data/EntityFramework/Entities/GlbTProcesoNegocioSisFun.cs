using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTProcesoNegocioSisFun
{
    public short ProNegocioCod { get; set; }

    public byte SisCodOri { get; set; }

    public string IdFuncionalidad { get; set; } = null!;
}
