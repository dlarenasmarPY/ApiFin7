using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpentregaRelConsumo
{
    public decimal POpentregaId { get; set; }

    public decimal POpconsumoId { get; set; }

    public double CantidadEntrega { get; set; }
}
