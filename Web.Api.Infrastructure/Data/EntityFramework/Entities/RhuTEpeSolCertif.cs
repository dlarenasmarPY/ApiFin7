using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEpeSolCertif
{
    public decimal EpeSolCerId { get; set; }

    public decimal PEpeSolId { get; set; }

    public decimal PEpeIdentId { get; set; }

    public string EpeMotivo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTEpeSolicitude PEpeSol { get; set; } = null!;
}
