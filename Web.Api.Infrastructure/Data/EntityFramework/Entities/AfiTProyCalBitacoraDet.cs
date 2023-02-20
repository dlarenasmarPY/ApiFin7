using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTProyCalBitacoraDet
{
    public decimal AfiProyCalDetId { get; set; }

    public decimal PAfiProyCalCabId { get; set; }

    public decimal PCorrMonDepId { get; set; }

    public decimal PDatContId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiValorLibro { get; set; }

    public int AfiSaldoVueje { get; set; }

    public int AfiSaldoVureal { get; set; }

    public double AfiDepAcumEjeAnt { get; set; }

    public double AfiFactorCorr { get; set; }

    public double AfiCorrMonVleje { get; set; }

    public double AfiCorrMonetVlper { get; set; }

    public double AfiCmdepAcumEje { get; set; }

    public double AfiCmdepAcumPer { get; set; }

    public double AfiValorAdep { get; set; }

    public double AfiDepAcumEje { get; set; }

    public double AfiDepPeriodo { get; set; }

    public double AfiValorNeto { get; set; }

    public double AfiTasaDep { get; set; }

    public short AfiMesesAdep { get; set; }

    public int AfiSvuhoras { get; set; }

    public int AfiSvuhorasReal { get; set; }

    public double AfiMontoDeterioro { get; set; }

    public double AfiCorrMonVlejeBien { get; set; }

    public double AfiCorrMonetVlperBien { get; set; }

    public double AfiDepAcumEjeBien { get; set; }

    public double AfiDepPeriodoBien { get; set; }

    public double AfiTasacionInicial { get; set; }

    public double AfiTotalAdiciones { get; set; }

    public double AfiValorResidualCm { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
