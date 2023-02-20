using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTInmuebleProyectoLog
{
    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public string InmuebleCodigo { get; set; } = null!;

    public string PryNumero { get; set; } = null!;

    public int DocEstadoOld { get; set; }

    public int DocEstadoNew { get; set; }

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public DateTime FechaUpdate { get; set; }

    public string ProcNombre { get; set; } = null!;
}
