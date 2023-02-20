using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTSaldosBodega
{
    public decimal SaldoBodegaId { get; set; }

    public DateTime FechaHoraSaldos { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PProductoId { get; set; }

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

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

    public double CostoMonedaCorregido { get; set; }

    public double CostoPromMonedaCorregido { get; set; }

    public decimal PSaldoEmpresaId { get; set; }

    public decimal PEntConsignadorId { get; set; }

    public decimal POpeLogtCabFifoId { get; set; }

    public double CostoMonedaSinCorr { get; set; }

    public double CostoPromMonedaSinCorr { get; set; }

    public virtual LogTEstadoProducto EstadoProdCodNavigation { get; set; } = null!;

    public virtual ICollection<LogTSaldosLogtUbicacionLote> LogTSaldosLogtUbicacionLotes { get; } = new List<LogTSaldosLogtUbicacionLote>();

    public virtual ExiTBodega PBodega { get; set; } = null!;

    public virtual ExiTProducto PProducto { get; set; } = null!;

    public virtual LogTSituacionContable SituacionContCodNavigation { get; set; } = null!;
}
