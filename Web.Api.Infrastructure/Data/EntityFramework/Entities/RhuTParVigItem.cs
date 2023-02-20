using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParVigItem
{
    public decimal VitId { get; set; }

    public decimal PItmParId { get; set; }

    public DateTime VitFecVigencia { get; set; }

    public decimal VitValPar1 { get; set; }

    public decimal VitValPar2 { get; set; }

    public decimal VitValPar3 { get; set; }

    public decimal VitValPar4 { get; set; }

    public decimal VitValPar5 { get; set; }

    public decimal VitValPar6 { get; set; }

    public decimal VitValPar7 { get; set; }

    public decimal VitValPar8 { get; set; }

    public decimal VitValPar9 { get; set; }

    public decimal VitValPar10 { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem PItmPar { get; set; } = null!;
}
