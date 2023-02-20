using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBaja
{
    public decimal BienBajaId { get; set; }

    public decimal PDatContId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public decimal AfiDctoDigitacion { get; set; }

    public int AfiCantidad { get; set; }

    public decimal PAfiOpeDetId { get; set; }

    public double AfiValorBaja { get; set; }

    public double AfiValorBajaMoneda { get; set; }

    public short TdoId { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public double AfiPorcentajeBaja { get; set; }

    public DateTime AfiFechaIngBaja { get; set; }

    public DateTime AfiFechaAprBaja { get; set; }

    public DateTime AfiFechaEjecBaja { get; set; }

    public decimal PCabOpeId { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public byte AfiContabiliza { get; set; }

    public byte ConEstCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
