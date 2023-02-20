using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCabeceraProgramacion
{
    public decimal ProgramacionId { get; set; }

    public decimal PTprId { get; set; }

    public DateTime FechaDigitacion { get; set; }

    public DateTime FechaAprobacion { get; set; }

    public string Usuario { get; set; } = null!;

    public string CodigoEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
