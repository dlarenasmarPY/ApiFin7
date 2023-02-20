using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTProductoCosto
{
    public decimal ProductoCostoId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PProductoId { get; set; }

    public short PerId { get; set; }

    public double CostoEstandar { get; set; }

    public double CostoEstandarTrib { get; set; }

    public double CostoEstandarSinCorr { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
