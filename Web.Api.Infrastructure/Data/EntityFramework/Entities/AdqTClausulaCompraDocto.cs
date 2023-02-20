using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTClausulaCompraDocto
{
    public decimal ClausulaDoctoId { get; set; }

    public decimal PClausulaId { get; set; }

    public short TdoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual AdqTClausulaCompra PClausula { get; set; } = null!;

    public virtual GlbTDocumento Tdo { get; set; } = null!;
}
