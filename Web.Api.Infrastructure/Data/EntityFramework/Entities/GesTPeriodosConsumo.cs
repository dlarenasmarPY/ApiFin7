using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GesTPeriodosConsumo
{
    public decimal PerConId { get; set; }

    public short PerConCod { get; set; }

    public string PerConDes { get; set; } = null!;

    public short DiasporPeriodo { get; set; }
}
