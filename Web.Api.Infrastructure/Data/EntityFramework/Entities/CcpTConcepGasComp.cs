using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTConcepGasComp
{
    public decimal CcpGasComId { get; set; }

    public decimal PConceptoGastoId { get; set; }

    public short TdoId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual CcpTConceptosGasto PConceptoGasto { get; set; } = null!;
}
