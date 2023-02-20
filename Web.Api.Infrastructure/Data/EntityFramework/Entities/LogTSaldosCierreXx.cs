using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTSaldosCierreXx
{
    public decimal SaldoCierreId { get; set; }

    public decimal PSaldoEmpresaId { get; set; }

    public decimal PSaldoBodegaId { get; set; }

    public DateTime FechaCierre { get; set; }

    public short PerId { get; set; }

    public double Cantidad { get; set; }

    public double Cantidad2 { get; set; }

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

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PProductoId { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public DateTime FechaHoraSaldos { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public double CostoMonedaCorregido { get; set; }

    public double CostoPromMonedaCorregido { get; set; }
}
