using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCarOfeItemDescto
{
    public decimal PCartaOfertaId { get; set; }

    public short ItemDesctoId { get; set; }

    public decimal PMonedaId { get; set; }

    public double Porcentaje { get; set; }

    public double MontoItem { get; set; }

    public double MontoItemLocal { get; set; }

    public virtual InmTItemDescuento ItemDescto { get; set; } = null!;
}
