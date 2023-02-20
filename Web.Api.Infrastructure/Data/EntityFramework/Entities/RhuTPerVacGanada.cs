using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTPerVacGanada
{
    public decimal VgaId { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime VgaFecAbono { get; set; }

    public decimal PItmTipAbonoId { get; set; }

    public decimal PItmTipVacId { get; set; }

    public short VgaDiasGanados { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;
}
