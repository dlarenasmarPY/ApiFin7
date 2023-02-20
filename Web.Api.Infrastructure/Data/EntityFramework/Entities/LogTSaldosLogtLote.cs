using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTSaldosLogtLote
{
    public decimal SaldoPorLoteId { get; set; }

    public decimal PLoteProductoId { get; set; }

    public decimal PUbicacionId { get; set; }

    public decimal PProductoId { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public double CantidadLote { get; set; }

    public double CantidadLote2 { get; set; }

    public double CostoMoneda { get; set; }

    public double CostoMonedaAlt { get; set; }

    public double CostoMonedaCorregido { get; set; }

    public double CostoPromMoneda { get; set; }

    public double CostoPromMonedaAlt { get; set; }

    public double CostoPromMonedaCorregido { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double CostoMonedaSinCorr { get; set; }

    public double CostoPromMonedaSinCorr { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }
}
