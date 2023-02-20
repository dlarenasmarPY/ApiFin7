using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFormaPagoBco
{
    public byte FormaPagoBanco { get; set; }

    public string FormaPagoGlosaBco { get; set; } = null!;
}
