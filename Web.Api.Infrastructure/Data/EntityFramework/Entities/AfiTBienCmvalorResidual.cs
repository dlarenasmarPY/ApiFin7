using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBienCmvalorResidual
{
    public decimal CmvalorResId { get; set; }

    public decimal PDatContId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiValorResidualCm { get; set; }

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

    public DateTime CabOpeFecha { get; set; }

    public decimal PCabOpeId { get; set; }

    public byte AfiContabiliza { get; set; }

    public double AfiCorrMonAcum { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
