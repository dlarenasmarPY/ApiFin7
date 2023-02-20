using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTLogAutorizaCotizacion
{
    public decimal PTprId { get; set; }

    public decimal PCotizacionId { get; set; }

    public double PrecioVentaInm { get; set; }

    public double PrecioFinal { get; set; }

    public DateTime FechaHora { get; set; }

    public string Usuario { get; set; } = null!;
}
