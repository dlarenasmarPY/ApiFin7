using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTurno
{
    public decimal TurnoId { get; set; }

    public decimal PEmpId { get; set; }

    public string TurnoCod { get; set; } = null!;

    public string TurnoDes { get; set; } = null!;

    public short HoraInicio { get; set; }

    public short HoraTermino { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
