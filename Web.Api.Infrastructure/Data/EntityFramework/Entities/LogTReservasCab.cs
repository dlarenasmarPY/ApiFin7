using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTReservasCab
{
    public decimal ReservasCabId { get; set; }

    public decimal PPedidoMaterialId { get; set; }

    public byte ConEstCod { get; set; }

    public virtual ICollection<LogTReservasDet> LogTReservasDets { get; } = new List<LogTReservasDet>();

    public virtual LogTPedidoMaterialCab PPedidoMaterial { get; set; } = null!;
}
