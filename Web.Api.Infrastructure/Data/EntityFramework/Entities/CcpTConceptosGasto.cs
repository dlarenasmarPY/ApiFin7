using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTConceptosGasto
{
    public decimal ConceptoGastoId { get; set; }

    public decimal PEmpId { get; set; }

    public short ConCcpCodGasto { get; set; }

    public string ConCcpGloGasto { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PCdiId { get; set; }

    public byte ConCcpUsaLibLegal { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<CcpTConcepGasComp> CcpTConcepGasComps { get; } = new List<CcpTConcepGasComp>();

    public virtual ICollection<CcpTMovimiento> CcpTMovimientos { get; } = new List<CcpTMovimiento>();

    public virtual GlbTEmpresa PEmp { get; set; } = null!;
}
