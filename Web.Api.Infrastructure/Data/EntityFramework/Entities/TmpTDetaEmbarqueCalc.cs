using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTDetaEmbarqueCalc
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal POcCabId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public decimal PEmbarqueDetId { get; set; }

    public decimal DetEmbCantFac { get; set; }

    public double DetEmbValorClau { get; set; }

    public double DetEmbPorcIncTot { get; set; }

    public double DetEmbCostoDirTot { get; set; }

    public double DetEmbPorcIncTotMod { get; set; }

    public double DetEmbCostoDirTotMod { get; set; }

    public double DetEmbCostoDirTotFinal { get; set; }

    public byte IndCostoDirFijo { get; set; }
}
