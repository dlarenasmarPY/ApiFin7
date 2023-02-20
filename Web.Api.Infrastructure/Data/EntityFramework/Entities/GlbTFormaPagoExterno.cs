using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFormaPagoExterno
{
    public short FormaPagoCodExt { get; set; }

    public string FormaPagoCodExtGlosa { get; set; } = null!;
}
