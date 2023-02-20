using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ParComuna
{
    public int CodComuna { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public int CodRegion { get; set; }

    public string? EstadoReg { get; set; }

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
