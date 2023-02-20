using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFormaPagoDet
{
    public decimal FormaPagoDetId { get; set; }

    public decimal PFormaPagoId { get; set; }

    public short TdoId { get; set; }
}
