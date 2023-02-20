using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegProgresivo
{
    public decimal FlegMprId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime FlegMprFecSolicitud { get; set; }

    public byte FlegMprDias { get; set; }

    public decimal FlegMcaEstado { get; set; }

    public decimal PNomConcId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTFlegMovProgresivo> RhuTFlegMovProgresivos { get; } = new List<RhuTFlegMovProgresivo>();
}
