using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemInfColConc
{
    public decimal InfCclId { get; set; }

    public decimal PClmInfId { get; set; }

    public decimal PConcRemId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemColumnasInf PClmInf { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;
}
