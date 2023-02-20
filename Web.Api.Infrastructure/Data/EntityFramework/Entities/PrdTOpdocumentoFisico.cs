using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpdocumentoFisico
{
    public decimal OpdocFisId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal POpdetId { get; set; }

    public decimal PForDocFisId { get; set; }

    public decimal PDocFisId { get; set; }

    public byte IndImpresion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
