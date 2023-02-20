using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoVisacion
{
    public short TvsCodigo { get; set; }

    public string TvsGlosa { get; set; } = null!;
}
