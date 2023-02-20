using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidadContacto
{
    public decimal EntConId { get; set; }

    public decimal PEntId { get; set; }

    public string EntConNombres { get; set; } = null!;

    public string EntConApePaterno { get; set; } = null!;

    public string EntConApeMaterno { get; set; } = null!;

    public string EntConSexo { get; set; } = null!;

    public string EntConGlosaCargo { get; set; } = null!;

    public string EntConMail { get; set; } = null!;

    public decimal PEntDirId { get; set; }

    public byte ProcesoCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
