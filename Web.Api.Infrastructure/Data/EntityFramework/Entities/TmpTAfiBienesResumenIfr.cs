using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTAfiBienesResumenIfr
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public string DivGlosa { get; set; } = null!;

    public short UniCodigo { get; set; }

    public string UniNombre { get; set; } = null!;

    public short AfiGrupoCod { get; set; }

    public string AfiGrupoDes { get; set; } = null!;

    public short AfiSubGrpCod { get; set; }

    public string AfiSubGrpDes { get; set; } = null!;

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public double AfiValorBajaMoneda { get; set; }

    public double AfiValorCompra { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiValorAdq { get; set; }

    public double AfiValorLibro { get; set; }

    public double AfiValorResidualCm { get; set; }

    public double AfiCorrMonVleje { get; set; }

    public double AfiValorAdqui { get; set; }

    public double AfiValorActivo { get; set; }

    public double AfiDepAcumEjeAnt { get; set; }

    public double AfiCmdepAcumEje { get; set; }

    public double AfiDepAcumEje { get; set; }

    public double AfiDepAcumTotal { get; set; }

    public double AfiTasacionInicial { get; set; }

    public double AfiValorNeto { get; set; }

    public int AfiTotalSgrupo { get; set; }

    public int AfiTotalGrupo { get; set; }

    public int AfiTotalUni { get; set; }

    public int AfiTotalDiv { get; set; }

    public int AfiTotalGneral { get; set; }

    public byte AfiStatus { get; set; }
}
