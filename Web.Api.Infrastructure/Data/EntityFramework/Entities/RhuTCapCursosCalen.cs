using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapCursosCalen
{
    public decimal CapCurCalId { get; set; }

    public decimal PCapCurEntId { get; set; }

    public DateTime CapCurCalFecIni { get; set; }

    public DateTime CapCurCalFecFin { get; set; }

    public short CapCurCalMinPar { get; set; }

    public short CapCurCalMaxPar { get; set; }

    public string CapCurLugar { get; set; } = null!;

    public decimal PCapRelId { get; set; }

    public decimal PBieEleId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapCursosEnt PCapCurEnt { get; set; } = null!;

    public virtual RhuTCapRelatore PCapRel { get; set; } = null!;

    public virtual ICollection<RhuTCapCursosHor> RhuTCapCursosHors { get; } = new List<RhuTCapCursosHor>();

    public virtual ICollection<RhuTCapEjecucion> RhuTCapEjecucions { get; } = new List<RhuTCapEjecucion>();
}
