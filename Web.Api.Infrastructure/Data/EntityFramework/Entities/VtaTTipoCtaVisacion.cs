using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoCtaVisacion
{
    public byte TcvCodigo { get; set; }

    public string TdeGlosa { get; set; } = null!;
}
