using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCarOfeDetItemFinan
{
    public decimal PCartaOfertaId { get; set; }

    public short ItemFinId { get; set; }

    public DateTime FechaVenc { get; set; }

    public double Porcentaje { get; set; }

    public double MontoItem { get; set; }

    public short MovDocCuota { get; set; }

    public double MontoItemLocal { get; set; }
}
