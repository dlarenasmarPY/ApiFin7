using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoResponsable
{
    public byte TreCodigo { get; set; }

    public string TreGlosa { get; set; } = null!;
}
