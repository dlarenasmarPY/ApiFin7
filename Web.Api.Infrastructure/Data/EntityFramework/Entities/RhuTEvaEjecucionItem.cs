using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaEjecucionItem
{
    public decimal IdEjecucionItem { get; set; }

    public decimal PidEjecucion { get; set; }

    public decimal PidItem { get; set; }

    public decimal PidFactor { get; set; }

    public double PesoItemSfactor { get; set; }

    public string TipoCalificacion { get; set; } = null!;

    public double NotaNumerica { get; set; }

    public decimal PidNota { get; set; }

    public int ValorPorcNota { get; set; }

    public string? TipoCalificacionApe { get; set; }

    public double? NotaNumericaApe { get; set; }

    public decimal? PidNotaApe { get; set; }

    public int? ValorPorcNotaApe { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTEvaEjecucion PidEjecucionNavigation { get; set; } = null!;
}
