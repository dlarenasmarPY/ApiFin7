using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoNegocioGenerico
{
    public byte TngCodigo { get; set; }

    public string TngGlosa { get; set; } = null!;

    public byte TngContabResultado { get; set; }
}
