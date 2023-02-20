using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFnqCalculosDet
{
    public decimal FnqCalDetId { get; set; }

    public decimal PFnqCalcId { get; set; }

    public string FnqCalcDetGlo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PFnqBasDetId { get; set; }

    public virtual RhuTFnqCalculo PFnqCalc { get; set; } = null!;
}
