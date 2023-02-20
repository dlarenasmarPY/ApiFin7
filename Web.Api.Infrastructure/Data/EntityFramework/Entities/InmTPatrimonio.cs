using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTPatrimonio
{
    public decimal PEntId { get; set; }

    public int IdenCorrelativo { get; set; }

    public string DescActivo { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public double MontoActivo { get; set; }
}
