using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapEjecucion
{
    public decimal CapEjeId { get; set; }

    public short EjeAno { get; set; }

    public decimal PCapCurEntId { get; set; }

    public decimal PCapCurCalId { get; set; }

    public decimal PCapPlanId { get; set; }

    public decimal PCapCurPreId { get; set; }

    public int CapEjeNroPar { get; set; }

    public decimal CapEjeItmValId { get; set; }

    public decimal CapEjeMtoCur { get; set; }

    public decimal CapEjeMtoVia { get; set; }

    public decimal CapEjeMtoTra { get; set; }

    public decimal CapEjeItmTipDoc { get; set; }

    public int CapEjeNumDoc { get; set; }

    public decimal CapEjeMtoDoc { get; set; }

    public decimal PCapRelId { get; set; }

    public decimal PCapTipEvalId { get; set; }

    public decimal PCapNotasId { get; set; }

    public string CapEjeObservacion { get; set; } = null!;

    public decimal CapEjeItmEstId { get; set; }

    public double MonVdmValor1 { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem CapEjeItmEst { get; set; } = null!;

    public virtual RhuTParItem CapEjeItmTipDocNavigation { get; set; } = null!;

    public virtual RhuTParItem CapEjeItmVal { get; set; } = null!;

    public virtual RhuTCapCursosCalen PCapCurCal { get; set; } = null!;

    public virtual RhuTCapCursosEnt PCapCurEnt { get; set; } = null!;

    public virtual RhuTCapCursosPrecio PCapCurPre { get; set; } = null!;

    public virtual RhuTCapPlane PCapPlan { get; set; } = null!;

    public virtual ICollection<RhuTCapEjeNomina> RhuTCapEjeNominas { get; } = new List<RhuTCapEjeNomina>();

    public virtual RhuTCapEjeSence? RhuTCapEjeSence { get; set; }
}
