using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueFecha
{
    public decimal EmbarqueFecId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public DateTime EmbFecEmbI { get; set; }

    public DateTime EmbFecEmbF { get; set; }

    public DateTime EmbFecEta { get; set; }

    public DateTime EmbFecRta { get; set; }

    public DateTime EmbFecBodI { get; set; }

    public DateTime EmbFecBodF { get; set; }

    public string Observacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
