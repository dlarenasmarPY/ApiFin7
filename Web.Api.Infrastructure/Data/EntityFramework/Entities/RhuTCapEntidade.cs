using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapEntidade
{
    public decimal PEntId { get; set; }

    public decimal PCapTipEntId { get; set; }

    public string CapNomCon { get; set; } = null!;

    public string CapTelCon { get; set; } = null!;

    public decimal PCapEstEntId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual ICollection<RhuTCapCursosEnt> RhuTCapCursosEnts { get; } = new List<RhuTCapCursosEnt>();

    public virtual RhuTCapTematica? RhuTCapTematica { get; set; }
}
