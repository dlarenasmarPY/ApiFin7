using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapPlane
{
    public decimal CapPlanId { get; set; }

    public short EjeAno { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public DateTime CapPlanFecInicio { get; set; }

    public DateTime CapPlanFecTermino { get; set; }

    public decimal PCapCurEntId { get; set; }

    public decimal CapPlanItmVal { get; set; }

    public decimal PItmParEstId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapCursosEnt PCapCurEnt { get; set; } = null!;

    public virtual RhuTParItem PItmParEst { get; set; } = null!;

    public virtual ICollection<RhuTCapEjecucion> RhuTCapEjecucions { get; } = new List<RhuTCapEjecucion>();

    public virtual ICollection<RhuTCapPlanesDet> RhuTCapPlanesDets { get; } = new List<RhuTCapPlanesDet>();
}
