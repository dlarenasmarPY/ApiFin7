using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueDoctosSeg
{
    public decimal EmbarqueDocSegId { get; set; }

    public decimal PEmbarqueDocId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public int EmbNumeroPoliza { get; set; }

    public double MontoAsegurado { get; set; }

    public double EmbPorcDeducible { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
