using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemProcPago
{
    public decimal ProcPagId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public decimal PCabEmiId { get; set; }

    public decimal PFormaPagoId { get; set; }

    public int ProcPagSec { get; set; }
}
