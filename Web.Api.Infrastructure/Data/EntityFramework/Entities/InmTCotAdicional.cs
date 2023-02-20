using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCotAdicional
{
    public decimal PCotizacionId { get; set; }

    public short AdiId { get; set; }

    public decimal PMonedaId { get; set; }

    public double PrecioVenta { get; set; }

    public double PrecioLista { get; set; }

    public byte Indicador { get; set; }

    public double PorcDesctoAdi { get; set; }

    public double MontoDesctoAdi { get; set; }

    public double PrecioFinalAdi { get; set; }
}
