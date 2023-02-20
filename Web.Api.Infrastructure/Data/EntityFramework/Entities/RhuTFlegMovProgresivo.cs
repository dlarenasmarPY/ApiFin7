using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFlegMovProgresivo
{
    public decimal PFlegMabId { get; set; }

    public decimal PFlegMprId { get; set; }

    public byte FlegMprDias { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFlegMovAbono PFlegMab { get; set; } = null!;

    public virtual RhuTFlegProgresivo PFlegMpr { get; set; } = null!;
}
