using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemHstDiferencia
{
    public decimal LiqDifId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PLiqId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public double LqTmontoLiquidoAnt { get; set; }

    public double LqTmontoLiquidoDif { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
