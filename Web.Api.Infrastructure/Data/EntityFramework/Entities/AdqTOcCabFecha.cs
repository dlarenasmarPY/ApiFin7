using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcCabFecha
{
    public decimal OcCabFechaId { get; set; }

    public decimal POcCabId { get; set; }

    public DateTime FechaEntrega { get; set; }

    public virtual AdqTOcCab POcCab { get; set; } = null!;
}
