using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTSaldosLogtUbicacionLote
{
    public decimal SaldoPorUbicacionLoteId { get; set; }

    public decimal PSaldoBodegaId { get; set; }

    public decimal PUbicacionId { get; set; }

    public decimal PLoteProductoId { get; set; }

    public double CantidadUbiLote { get; set; }

    public double CantidadUbiLote2 { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PSaldoPorLoteId { get; set; }

    public virtual LogTSaldosBodega PSaldoBodega { get; set; } = null!;
}
