using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapParTipEval
{
    public decimal CapTipEvalId { get; set; }

    public string CapTipEvalDes { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTCapCursosEnt> RhuTCapCursosEnts { get; } = new List<RhuTCapCursosEnt>();

    public virtual ICollection<RhuTCapParNota> RhuTCapParNota { get; } = new List<RhuTCapParNota>();
}
