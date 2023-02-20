using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTSeguimientoCliente
{
    public decimal SeguiId { get; set; }

    public string CliRut { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string SeguiGlosa { get; set; } = null!;

    public decimal PTprId { get; set; }

    public string Telefono { get; set; } = null!;

    public decimal PFormaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
