using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBitacoraVidaIfr
{
    public decimal BitacoraVidaIfrsId { get; set; }

    public decimal PDatContId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public byte AfiCambioVida { get; set; }

    public int AfiVuorgIng { get; set; }

    public int AfiVuejeIng { get; set; }

    public int AfiVurealIng { get; set; }

    public byte AfiCambioMtdoDeprec { get; set; }

    public byte AfiMtoDeprecIng { get; set; }

    public byte AfiCambioValorRes { get; set; }

    public double AfiValorResIng { get; set; }

    public short AfiMesesAdep { get; set; }

    public short AfiEjeUltCal { get; set; }

    public byte AfiPerMesUltCal { get; set; }

    public int AfiVuorgUltCal { get; set; }

    public int AfiVuejeUltCal { get; set; }

    public int AfiVurealUltCal { get; set; }

    public byte AfiMtdoDeprecUltCal { get; set; }

    public double AfiValorResUltCal { get; set; }

    public DateTime AfiFechaIngreso { get; set; }

    public DateTime AfiFechaMod { get; set; }

    public DateTime AfiFechaAprob { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
