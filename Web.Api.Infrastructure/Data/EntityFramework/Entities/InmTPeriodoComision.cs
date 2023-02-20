using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTPeriodoComision
{
    public int Periodo { get; set; }

    public decimal PEmpId { get; set; }

    public DateTime FechaInicio { get; set; }

    public DateTime FechaTermino { get; set; }

    public short CodigoEstadoPeriodo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
