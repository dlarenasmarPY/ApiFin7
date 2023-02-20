using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTComuna
{
    public int CmuCodigo { get; set; }

    public string CmuNombre { get; set; } = null!;

    public int CmuCodTesoreria { get; set; }

    public int CmuDdn { get; set; }

    public byte RegCodigo { get; set; }

    public int CiuCodigo { get; set; }
}
