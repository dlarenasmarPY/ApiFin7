using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidadDireccion
{
    public decimal EntDirId { get; set; }

    public decimal PEntId { get; set; }

    public string EntDirDireccion { get; set; } = null!;

    public int CmuCodigo { get; set; }

    public int CiuCodigo { get; set; }

    public string EntDirCodPostal { get; set; } = null!;

    public string EntDirFono { get; set; } = null!;

    public string EntDirFax { get; set; } = null!;

    public byte ProcesoCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string? EntDirDireccionLarga { get; set; }
}
