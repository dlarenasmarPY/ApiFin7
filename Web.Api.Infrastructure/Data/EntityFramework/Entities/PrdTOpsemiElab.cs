using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpsemiElab
{
    public decimal OpsemiElabId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal POpdetId { get; set; }

    public decimal PForSemiElabId { get; set; }

    public decimal PFormulaIdSe { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public double CantEstd { get; set; }

    public decimal SconEstd { get; set; }

    public double CantAprob { get; set; }

    public decimal SconAprob { get; set; }

    public decimal POperacionId { get; set; }

    public double CostoEstandar { get; set; }

    public double CostoEstandarTrib { get; set; }

    public double CostoEstandarTotal { get; set; }

    public double CostoEstandarTribTotal { get; set; }

    public double ValorUniOpeMoneda { get; set; }

    public double ValorOpeMoneda { get; set; }

    public double ValorUniOpeMonedaCorregido { get; set; }

    public double ValorOpeMonedaCorregido { get; set; }

    public int SecuenciaFor { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double ValorUniOpeMonedaAlt { get; set; }

    public double ValorOpeMonedaAlt { get; set; }
}
