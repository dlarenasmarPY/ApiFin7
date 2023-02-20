using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTPedidoMaterialDetEspTec
{
    public decimal PedidoMaterialDetEspTecId { get; set; }

    public decimal PPedidoMaterialDetId { get; set; }

    public decimal PProductoEspTecId { get; set; }

    public decimal PProductoEspTecDetId { get; set; }

    public virtual LogTPedidoMaterialDet PPedidoMaterialDet { get; set; } = null!;

    public virtual ExiTProductosEspTecCab PProductoEspTec { get; set; } = null!;
}
