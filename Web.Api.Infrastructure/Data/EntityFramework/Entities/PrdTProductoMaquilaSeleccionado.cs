using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTProductoMaquilaSeleccionado
{
    public decimal? POpeLogtCabId { get; set; }

    public decimal? ProductoId { get; set; }

    public decimal? FormulaId { get; set; }

    public decimal? CantidadProducir { get; set; }
}
