using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTAdicionalVentum
{
    public decimal PTprId { get; set; }

    public short AdiId { get; set; }

    public string AdiGlosa { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public double Monto { get; set; }

    public decimal PMonedaCostoId { get; set; }

    public double ValorCosto { get; set; }
}
