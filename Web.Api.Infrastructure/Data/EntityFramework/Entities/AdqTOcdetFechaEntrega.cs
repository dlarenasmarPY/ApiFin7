using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcdetFechaEntrega
{
    public decimal OcDetFecEntregaId { get; set; }

    public decimal POcDetId { get; set; }

    public DateTime FechaEntrega { get; set; }

    public DateTime FechaEntregaOld { get; set; }

    public byte ConEstCod { get; set; }

    public double CantPendiente { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public DateTime FechaCompromisoProv { get; set; }

    public DateTime FechaEntregaRealProv { get; set; }
}
