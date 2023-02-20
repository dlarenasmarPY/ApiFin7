using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTRubrosEntidade
{
    public decimal RubroEntidadId { get; set; }

    public decimal PRubroId { get; set; }

    public decimal PEntId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual AdqTRubro PRubro { get; set; } = null!;
}
