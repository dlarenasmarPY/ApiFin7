using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTUbicacionDt
{
    public short UblCodigo { get; set; }

    public string UblGlosa { get; set; } = null!;
}
