using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCotDividendo
{
    public decimal PCotizacionId { get; set; }

    public short ItemFinId { get; set; }

    public byte AnosDividendo { get; set; }

    public double CotTasaCambio { get; set; }

    public double Dividendo { get; set; }

    public double RentaLiquida { get; set; }
}
