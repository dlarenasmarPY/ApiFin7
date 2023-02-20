using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEpeSolPermiso
{
    public decimal EpeSolPerId { get; set; }

    public decimal PEpeSolId { get; set; }

    public decimal PEpeIdentId { get; set; }

    public DateTime EpeFecInicio { get; set; }

    public DateTime EpeFecTermino { get; set; }

    public short EpeDias { get; set; }

    public DateTime EpeHraInicio { get; set; }

    public DateTime EpeHraTermino { get; set; }

    public short EpeHoras { get; set; }

    public string EpeMotivo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte EpeTpDias { get; set; }

    public byte EpeJornada { get; set; }

    public virtual RhuTEpeSolicitude PEpeSol { get; set; } = null!;
}
