using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTBienCentroRespHist
{
    public decimal BienCrespHisId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public decimal AfiDctoDigitacion { get; set; }

    public decimal AfiCorrelativo { get; set; }

    public decimal PCreId { get; set; }

    public double AfiPorcentajeResp { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
