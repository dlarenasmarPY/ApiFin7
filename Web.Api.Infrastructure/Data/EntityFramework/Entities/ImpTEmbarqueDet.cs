using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTEmbarqueDet
{
    public decimal EmbarqueDetId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public decimal PEmbarqueDocId { get; set; }

    public decimal POcCabId { get; set; }

    public decimal POcDetId { get; set; }

    public int Linea { get; set; }

    public int Item { get; set; }

    public decimal PTipoPackingId { get; set; }

    public decimal DetEmbCantDoc { get; set; }

    public decimal DetEmbCantFac { get; set; }

    public decimal DetEmbCantOcpen { get; set; }

    public double DetEmbPorcInc { get; set; }

    public double DetEmbValorClau { get; set; }

    public double DetEmbCostoDir { get; set; }

    public double? MonFuncTasaCambio { get; set; }

    public double MonFuncMonto { get; set; }

    public byte IndCostoDirFijo { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string CodOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PProductoEmbarqueId { get; set; }

    public double DetEmbValorClauCal { get; set; }
}
