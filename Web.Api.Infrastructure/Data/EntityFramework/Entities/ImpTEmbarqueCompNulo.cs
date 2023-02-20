using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueCompNulo
{
    public decimal EmbarqueCompId { get; set; }

    public decimal PEmbarqueDocId { get; set; }

    public byte IndContabilizaConcepto { get; set; }

    public decimal PMovLlgId { get; set; }

    public decimal PCabOpeId { get; set; }

    public DateTime FechaReversa { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
