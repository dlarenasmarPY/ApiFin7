using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoDoctoGenerico
{
    public byte TdgCodigo { get; set; }

    public string TdgGlosa { get; set; } = null!;
}
