using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFnqSolicitudDet
{
    public decimal FnqSolDetId { get; set; }

    public decimal PFnqSolId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime FnqSolDetFecFiniquito { get; set; }

    public DateTime FnqSolDetFecAviso { get; set; }

    public DateTime FnqSolDetFecPago { get; set; }

    public decimal PFnqCauId { get; set; }

    public decimal PFnqCauReaId { get; set; }

    public decimal PItmFnqSolEstDetId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTFnqCausale PFnqCau { get; set; } = null!;

    public virtual RhuTFnqCausalReal PFnqCauRea { get; set; } = null!;

    public virtual RhuTFnqSolicitud PFnqSol { get; set; } = null!;

    public virtual RhuTParItem PItmFnqSolEstDet { get; set; } = null!;

    public virtual ICollection<RhuTFnqCalculo> RhuTFnqCalculos { get; } = new List<RhuTFnqCalculo>();
}
