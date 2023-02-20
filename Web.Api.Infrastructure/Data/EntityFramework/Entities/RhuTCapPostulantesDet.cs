using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapPostulantesDet
{
    public decimal CapPosDetId { get; set; }

    public decimal PCapPostId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PCapCurId { get; set; }

    public decimal PItmParEstId { get; set; }

    public decimal PCapEjeDetId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapCurso PCapCur { get; set; } = null!;

    public virtual RhuTCapPostulante PCapPost { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTParItem PItmParEst { get; set; } = null!;
}
