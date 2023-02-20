using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoDevolucion
{
    public byte TdpCodigo { get; set; }

    public string TdpGlosa { get; set; } = null!;

    public byte TdpUsaBodega { get; set; }
}
