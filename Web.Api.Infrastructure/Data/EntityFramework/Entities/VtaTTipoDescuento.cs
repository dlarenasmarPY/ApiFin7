using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoDescuento
{
    public short TdeCodigo { get; set; }

    public string TdeGlosa { get; set; } = null!;
}
