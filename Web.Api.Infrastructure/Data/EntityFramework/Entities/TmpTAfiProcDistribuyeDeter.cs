using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTAfiProcDistribuyeDeter
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public decimal PDatContId { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public short EjeAnoDet { get; set; }

    public byte PerMesDet { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public int OrigenProceso { get; set; }

    public decimal PPdcId { get; set; }

    public int AfiCodigoUge { get; set; }

    public decimal PCreId { get; set; }

    public double AfiMontoDeterioro { get; set; }

    public double AfiDeterioroAcum { get; set; }

    public double AfiValorNeto { get; set; }

    public double AfiValorResidual { get; set; }

    public byte AfiStatus { get; set; }

    public string AfiGlosaLarga { get; set; } = null!;
}
