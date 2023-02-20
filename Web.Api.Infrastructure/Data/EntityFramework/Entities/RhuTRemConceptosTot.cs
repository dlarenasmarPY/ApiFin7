using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemConceptosTot
{
    public decimal ConcTotId { get; set; }

    public decimal PConcPerId { get; set; }

    public decimal PConcRemId { get; set; }

    public string CttTipoOperacion { get; set; } = null!;

    public byte CttIndAfecPerLiq { get; set; }

    public byte CttIndAfecPerDev { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemConceptosPer PConcPer { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;
}
