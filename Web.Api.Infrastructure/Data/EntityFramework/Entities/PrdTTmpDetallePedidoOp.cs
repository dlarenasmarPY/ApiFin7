using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTmpDetallePedidoOp
{
    public string CodOwner { get; set; } = null!;

    public int Item { get; set; }

    public decimal PProductoId { get; set; }

    public double CantEstd { get; set; }

    public double CantPedidoAnt { get; set; }

    public double StockDisponible { get; set; }

    public double Cantidad { get; set; }
}
