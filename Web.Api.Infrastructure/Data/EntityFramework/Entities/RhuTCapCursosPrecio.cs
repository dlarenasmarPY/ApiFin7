using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapCursosPrecio
{
    public decimal CapCurPreId { get; set; }

    public decimal PCapCurEntId { get; set; }

    public DateTime CapCurPreFecVig { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal CapMtoCur { get; set; }

    public decimal CapMtoParCur { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapCursosEnt PCapCurEnt { get; set; } = null!;

    public virtual ICollection<RhuTCapEjecucion> RhuTCapEjecucions { get; } = new List<RhuTCapEjecucion>();
}
