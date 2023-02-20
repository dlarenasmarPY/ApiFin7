using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTmpCierreOp
{
    public string CodOwner { get; set; } = null!;

    public decimal POpcabId { get; set; }

    public decimal Saldo { get; set; }

    public string IndProceso { get; set; } = null!;

    public string ErrGlosa { get; set; } = null!;
}
