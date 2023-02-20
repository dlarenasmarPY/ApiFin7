using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTSaldosCierreLote
{
    public decimal SaldoCierreLoteId { get; set; }

    public decimal PSaldoCierreId { get; set; }

    public decimal PLoteProductoId { get; set; }

    public decimal PUbicacionId { get; set; }

    public DateTime FechaHoraSaldos { get; set; }

    public DateTime FechaCierre { get; set; }

    public double Cantidad { get; set; }

    public double Cantidad2 { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public decimal POpeLogtDetserlotId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double CostoPromMonedaCorregido { get; set; }

    public double CostoMonedaCorregido { get; set; }

    public decimal PSaldoCierreLoteValId { get; set; }
}
