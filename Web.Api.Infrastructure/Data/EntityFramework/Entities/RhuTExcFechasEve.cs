using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTExcFechasEve
{
    public decimal FecEveId { get; set; }

    public decimal PItmEveAsiId { get; set; }

    public decimal PPerRemId { get; set; }

    public DateTime FecEveInicio { get; set; }

    public DateTime FecEveTermino { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem PItmEveAsi { get; set; } = null!;

    public virtual RhuTRemPeriodo PPerRem { get; set; } = null!;
}
