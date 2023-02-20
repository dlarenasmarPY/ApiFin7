using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCotItemFinan
{
    public decimal PCotizacionId { get; set; }

    public short ItemFinId { get; set; }

    public decimal PMonedaId { get; set; }

    public double Porcentaje { get; set; }

    public double MontoItem { get; set; }

    public double MontoItemLocal { get; set; }

    public string CotDetGlosa { get; set; } = null!;
}
