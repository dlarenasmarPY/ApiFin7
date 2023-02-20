using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCarOfeItemFinan
{
    public decimal PCartaOfertaId { get; set; }

    public short ItemFinId { get; set; }

    public decimal PMonedaId { get; set; }

    public double Porcentaje { get; set; }

    public double MontoItem { get; set; }

    public double MontoItemLocal { get; set; }

    public double PorcDescto { get; set; }

    public double MontoDescto { get; set; }

    public byte IndAutDescto { get; set; }

    public string RefId { get; set; } = null!;

    public int RefInstId { get; set; }

    public DateTime RefFechaVcto { get; set; }

    public decimal PEmpIdRi { get; set; }

    public short DivCodigoRi { get; set; }

    public double MontoItemOr { get; set; }

    public double MontoItemLocalOr { get; set; }

    public double MontoItemBono { get; set; }

    public double MontoItemBonoLocal { get; set; }

    public virtual InmTItemFinanciamiento ItemFin { get; set; } = null!;
}
