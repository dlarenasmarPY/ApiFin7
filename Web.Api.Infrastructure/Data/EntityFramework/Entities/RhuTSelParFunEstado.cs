using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelParFunEstado
{
    public string IdFuncionalidad { get; set; } = null!;

    public string CodEstado { get; set; } = null!;

    public string TipoEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
