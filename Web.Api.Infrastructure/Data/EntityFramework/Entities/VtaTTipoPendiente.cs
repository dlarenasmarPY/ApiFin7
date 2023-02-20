using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoPendiente
{
    public short TpeCodigo { get; set; }

    public string TpeGlosa { get; set; } = null!;

    public short TvsCodigo { get; set; }

    public string TpeGlosaCorta { get; set; } = null!;
}
