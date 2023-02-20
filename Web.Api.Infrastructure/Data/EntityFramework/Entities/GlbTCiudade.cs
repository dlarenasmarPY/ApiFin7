using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTCiudade
{
    public int CiuCodigo { get; set; }

    public string CiuNombre { get; set; } = null!;
}
