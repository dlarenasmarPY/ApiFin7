using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapPlanesDet
{
    public decimal CapPlanDetId { get; set; }

    public decimal PCapPlanId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PCapEjeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapPlane PCapPlan { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;
}
