using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogtPedidoMaterialDetCcosto
{
    public decimal PPedidoMaterialDetId { get; set; }

    public int Linea { get; set; }

    public decimal PCreId { get; set; }

    public double Monto { get; set; }
}
