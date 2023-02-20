using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEpeParametro
{
    public decimal EpeParamId { get; set; }

    public decimal PEmpId { get; set; }

    public byte EpeMailPermisos { get; set; }

    public byte EpeMailFlegal { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string EpeMailRrHh { get; set; } = null!;
}
