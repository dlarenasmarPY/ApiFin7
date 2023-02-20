using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTExcPago
{
    public decimal ExcPagId { get; set; }

    public decimal PExcId { get; set; }

    public decimal PTpaId { get; set; }

    public decimal PPerId { get; set; }

    public double ExcPagCargo { get; set; }

    public double ExcPagAbono { get; set; }

    public decimal PItmEstExcPagId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTExcepcione PExc { get; set; } = null!;

    public virtual RhuTParItem PItmEstExcPag { get; set; } = null!;

    public virtual RhuTExcTipPago PTpa { get; set; } = null!;
}
