using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoReajuste
{
    public byte TirId { get; set; }

    public string TirGlosa { get; set; } = null!;
}
