using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTSaldosLogtSerie
{
    public decimal SaldoPorSerieId { get; set; }

    public decimal PSaldoBodegaId { get; set; }

    public decimal PSaldoPorUbicacionLoteId { get; set; }

    public decimal PUbicacionId { get; set; }

    public decimal PSerieProductoId { get; set; }

    public double CantidadSerie { get; set; }

    public double CantidadSerie2 { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
