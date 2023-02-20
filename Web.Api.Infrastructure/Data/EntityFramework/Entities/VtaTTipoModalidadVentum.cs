using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoModalidadVentum
{
    public short TmvCodigo { get; set; }

    public string TmvGlosa { get; set; } = null!;

    public short TmvCodigoSii { get; set; }
}
