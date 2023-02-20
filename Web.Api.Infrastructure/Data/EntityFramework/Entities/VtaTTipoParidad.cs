using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoParidad
{
    public byte TpdTipoParidad { get; set; }

    public string TpdGlosa { get; set; } = null!;
}
