using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTModulo
{
    public byte TmatModulo { get; set; }

    public string TmatModuloGlosa { get; set; } = null!;
}
