using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCarOfeProductoAdi
{
    public decimal PCartaOfertaId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public double PrecioVenta { get; set; }

    public double PrecioLista { get; set; }

    public byte Indicador { get; set; }

    public double PorcDesctoRel { get; set; }

    public double MontoDesctoRel { get; set; }

    public double PrecioFinalRel { get; set; }
}
