using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTCalculoAporte
{
    public decimal CalculoAporteId { get; set; }

    public decimal PAfiAporteId { get; set; }

    public decimal PDatContId { get; set; }

    public decimal PCorrMonDepId { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiValorLibro { get; set; }

    public double AfiDepAcumEjeAnt { get; set; }

    public double AfiFactorCorr { get; set; }

    public double AfiCorrMonVleje { get; set; }

    public double AfiCorrMonetVlper { get; set; }

    public double AfiCmdepAcumEje { get; set; }

    public double AfiCmdepAcumPer { get; set; }

    public double AfiValorAdep { get; set; }

    public double AfiTasaDep { get; set; }

    public int AfiSaldoVuejeAdi { get; set; }

    public int AfiSaldoVurealAdi { get; set; }

    public short AfiMesesAdep { get; set; }

    public double AfiDepAcumEje { get; set; }

    public double AfiDepPeriodo { get; set; }

    public double AfiValorNeto { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public decimal PCabOpeId { get; set; }

    public byte AfiContabiliza { get; set; }

    public double AfiCorrMonAcum { get; set; }

    public double AfiMontoDeterioro { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
