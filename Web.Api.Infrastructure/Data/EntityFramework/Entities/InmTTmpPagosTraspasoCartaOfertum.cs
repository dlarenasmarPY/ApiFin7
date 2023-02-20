using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTmpPagosTraspasoCartaOfertum
{
    public string Usuario { get; set; } = null!;

    public decimal PCartaOfertaId { get; set; }

    public short ItemFinId { get; set; }

    public double MontoItem { get; set; }

    public double Pagado { get; set; }

    public byte IndConformaPventa { get; set; }
}
