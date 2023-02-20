using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTMotivo
{
    public decimal GlbMotivoId { get; set; }

    public string GlbMotivoGlosa { get; set; } = null!;

    public string GlbMotivoNomCorto { get; set; } = null!;

    public short GlbTipoMotivo { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
