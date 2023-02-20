using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTAfiInfProyCalculoRe
{
    public string CodOwner { get; set; } = null!;

    public decimal PDatContId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string DivGlosa { get; set; } = null!;

    public string UniNombre { get; set; } = null!;

    public short AfiGrupoCod { get; set; }

    public short AfiSubGrpCod { get; set; }

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public string AfiGrupoDes { get; set; } = null!;

    public string AfiSubGrpDes { get; set; } = null!;

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiValorLibro { get; set; }

    public double AfiCorrMonVleje { get; set; }

    public double AfiCorrMonetVlper { get; set; }

    public double AfiValorActivo { get; set; }

    public double AfiValorResidualCm { get; set; }

    public double AfiDepAcumEjeAnt { get; set; }

    public double AfiCmdepAcumEje { get; set; }

    public double AfiCmdepAcumPer { get; set; }

    public double AfiDepAcumEje { get; set; }

    public double AfiDepPeriodo { get; set; }

    public double AfiDepAcumTotal { get; set; }

    public double AfiTasacionInicial { get; set; }

    public double AfiValorNeto { get; set; }

    public double AfiValorNeto2 { get; set; }

    public double AfiDeterioro { get; set; }

    public double AfiDeterioroAcum { get; set; }

    public double AfiTotalAdiciones { get; set; }
}
