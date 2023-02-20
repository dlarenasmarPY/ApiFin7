using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCalculoAporte
{
    public decimal PAfiAporteId { get; set; }

    public int AfiFolio { get; set; }

    public decimal PDatContId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

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

    public double AfiCorrMonAcum { get; set; }

    public double AfiMontoDeterioro { get; set; }
}
