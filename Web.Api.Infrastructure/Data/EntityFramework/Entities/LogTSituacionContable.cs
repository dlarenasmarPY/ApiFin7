using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTSituacionContable
{
    public byte SituacionContCod { get; set; }

    public string SituacionContDes { get; set; } = null!;

    public byte AccionContCod { get; set; }

    public virtual LogTAccionContable AccionContCodNavigation { get; set; } = null!;

    public virtual ICollection<ExiTGruposContablesCuenta> ExiTGruposContablesCuenta { get; } = new List<ExiTGruposContablesCuenta>();

    public virtual ICollection<LogTLotesProducto> LogTLotesProductos { get; } = new List<LogTLotesProducto>();

    public virtual ICollection<LogTOperacionesLogtDet> LogTOperacionesLogtDets { get; } = new List<LogTOperacionesLogtDet>();

    public virtual ICollection<LogTReservasDet> LogTReservasDets { get; } = new List<LogTReservasDet>();

    public virtual ICollection<LogTSaldosBodega> LogTSaldosBodegas { get; } = new List<LogTSaldosBodega>();

    public virtual ICollection<LogTSeriesProducto> LogTSeriesProductos { get; } = new List<LogTSeriesProducto>();
}
