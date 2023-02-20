using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtDetPacking
{
    public decimal OpeLogtDetPacId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public decimal POpeLogtDetserlotId { get; set; }

    public decimal PTipoPackingId { get; set; }

    public decimal PEmbId { get; set; }

    public string PackingCod { get; set; } = null!;

    public string PackingSello { get; set; } = null!;

    public string GlosaExis { get; set; } = null!;

    public string IndEmbarque { get; set; } = null!;

    public double CantSalida { get; set; }

    public double CantSalidaStock { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal POpeLogtDetSerId { get; set; }
}
