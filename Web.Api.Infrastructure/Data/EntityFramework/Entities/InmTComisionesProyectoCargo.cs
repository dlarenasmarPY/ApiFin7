using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTComisionesProyectoCargo
{
    public decimal PEmpId { get; set; }

    public decimal PTprId { get; set; }

    public decimal PCargoId { get; set; }

    public double Pro { get; set; }

    public double Esc { get; set; }

    public double Rec { get; set; }

    public byte ClasificaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
