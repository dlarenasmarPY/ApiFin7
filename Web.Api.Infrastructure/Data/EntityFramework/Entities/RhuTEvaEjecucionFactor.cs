using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaEjecucionFactor
{
    public decimal IdEjecucionFactor { get; set; }

    public decimal PidEjecucion { get; set; }

    public decimal PidFactor { get; set; }

    public double PesoFactorSform { get; set; }

    public double TotalNotasItems { get; set; }

    public int ValorPorcNota { get; set; }

    public double? TotalNotasItemsApe { get; set; }

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
