using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionReserva
{
    public int NumeroReferencia { get; set; }

    public decimal PReservasDetId { get; set; }

    public decimal PCotizDetId { get; set; }

    public byte IndAdjudicacion { get; set; }

    public double CantidadAdjudica { get; set; }
}
