using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTEstadoProducto
{
    public byte EstadoProdCod { get; set; }

    public string EstadoProdDes { get; set; } = null!;

    public virtual ICollection<LogTLotesProducto> LogTLotesProductos { get; } = new List<LogTLotesProducto>();

    public virtual ICollection<LogTReservasDet> LogTReservasDets { get; } = new List<LogTReservasDet>();

    public virtual ICollection<LogTSaldosBodega> LogTSaldosBodegas { get; } = new List<LogTSaldosBodega>();

    public virtual ICollection<LogTSeriesProducto> LogTSeriesProductos { get; } = new List<LogTSeriesProducto>();
}
