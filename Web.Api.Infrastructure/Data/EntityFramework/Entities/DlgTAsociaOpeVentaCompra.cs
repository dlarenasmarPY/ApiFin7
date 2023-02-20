using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTAsociaOpeVentaCompra
{
    public decimal PEmpId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PEmpIdCompra { get; set; }

    public decimal PTipoOpeIdCompra { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
