using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidadBitacoraEstado
{
    public decimal EntBitId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public string EntBitIndEstado { get; set; } = null!;

    public string EntBitGlosaEstado { get; set; } = null!;

    public DateTime EntBitFecEstado { get; set; }

    public string EntBitUsuEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
