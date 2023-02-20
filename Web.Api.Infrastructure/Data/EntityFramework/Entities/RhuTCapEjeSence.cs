using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapEjeSence
{
    public decimal CapEjeSenId { get; set; }

    public decimal PCapEjeId { get; set; }

    public decimal CapEjeSenNroReg { get; set; }

    public DateTime CapEjeSenFecIng { get; set; }

    public DateTime CapEjeSenFecPre { get; set; }

    public DateTime CapEjeSenFecLiq { get; set; }

    public decimal CapEjeSenFraSol { get; set; }

    public decimal CapEjeSenFraApr { get; set; }

    public decimal CapEjeSenViaSol { get; set; }

    public decimal CapEjeSenViaApr { get; set; }

    public decimal CapEjeSenTraSol { get; set; }

    public decimal CapEjeSenTraApr { get; set; }

    public int CapEjeSenPerInf { get; set; }

    public decimal PCapEjeSenEstId { get; set; }

    public string CapEjeSenObserv { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapEjecucion PCapEje { get; set; } = null!;

    public virtual RhuTParItem PCapEjeSenEst { get; set; } = null!;
}
