using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTDevolucionAsigCon
{
    public string? CodOwner { get; set; }

    public decimal? POpcabId { get; set; }

    public decimal? PProductoId { get; set; }

    public decimal? PLoteProductoId { get; set; }

    public double? Devolucion { get; set; }

    public int? Marcado { get; set; }

    public decimal? OpeLogtDetId { get; set; }
}
