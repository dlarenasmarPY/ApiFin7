using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoSolActivarDet
{
    public decimal CtoSolActDetId { get; set; }

    public decimal PCtoSolActId { get; set; }

    public decimal PCtoOldId { get; set; }

    public decimal PCtoNewId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoSolActivar PCtoSolAct { get; set; } = null!;
}
