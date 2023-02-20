using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBienDatCont
{
    public decimal DatContId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public decimal PAfiOpeDetId { get; set; }

    public short AfiEjercicioInc { get; set; }

    public byte AfiPerMesInc { get; set; }

    public short AfiEjercicioInDep { get; set; }

    public byte AfiPerMesInDep { get; set; }

    public int AfiVidaUtilMeses { get; set; }

    public double AfiValorResidual { get; set; }

    public double AfiValorAdq { get; set; }

    public int AfiSaldoVuejeIng { get; set; }

    public int AfiSaldoVureal { get; set; }

    public int AfiSaldoVueje { get; set; }

    public int AfiSaldoVurealIng { get; set; }

    public double AfiDepAcumEjeAntIng { get; set; }

    public double AfiDepAcumEjeIng { get; set; }

    public double AfiCorrMonVlejeIng { get; set; }

    public double AfiCmdepAcumEjeIng { get; set; }

    public double AfiRetAcumIng { get; set; }

    public double AfiValorNetoIng { get; set; }

    public double AfiValorLibro { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public decimal PCabOpeId { get; set; }

    public byte AfiContabiliza { get; set; }

    public byte AfiEstado { get; set; }

    public byte AfiTipoBien { get; set; }

    public double AfiCorrMonAcumIng { get; set; }

    public double AfiMontoCrFiscal { get; set; }

    public double AfiValorResidualCm { get; set; }

    public byte AfiUsaDepHoras { get; set; }

    public decimal AfiVuhorasOriginal { get; set; }

    public int AfiSvuhoras { get; set; }

    public int AfiSvuhorasReal { get; set; }

    public short AfiEjerIncOriginal { get; set; }

    public int AfiPerMesInOri { get; set; }

    public byte AfiEsHistorico { get; set; }

    public byte AfiTipoContabilizacion { get; set; }

    public byte AfiUsaCrFiscal { get; set; }

    public byte AfiEstadoCrdto { get; set; }

    public double AfiTasacionInicial { get; set; }

    public DateTime AfiFechaBaja { get; set; }

    public DateTime AfiFechaAprob { get; set; }

    public DateTime AfiFechaActiv { get; set; }

    public double AfiCantidadVigente { get; set; }

    public decimal PCabOpeIdRevCalOri { get; set; }

    public decimal PCabOpeIdContCalCrd { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
