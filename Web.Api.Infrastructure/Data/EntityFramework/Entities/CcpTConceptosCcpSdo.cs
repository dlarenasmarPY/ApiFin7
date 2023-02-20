using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTConceptosCcpSdo
{
    public decimal ConceptoCcpSdoId { get; set; }

    public decimal PConceptoCcpId { get; set; }

    public decimal PProcConcId { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PConcRemId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual CcpTConceptosCcp PConceptoCcp { get; set; } = null!;

    public virtual RhuTRemProceso PProcRem { get; set; } = null!;
}
