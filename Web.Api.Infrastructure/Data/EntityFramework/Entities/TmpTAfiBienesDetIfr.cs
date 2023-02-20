using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTAfiBienesDetIfr
{
    public string CodOwner { get; set; } = null!;

    public decimal PDatContId { get; set; }

    public decimal PCodigoBienId { get; set; }

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

    public string AfiDescripcion { get; set; } = null!;

    public byte AfiTipoBien { get; set; }

    public string AfiCodAnterior { get; set; } = null!;

    public string AfiCodBarraBien { get; set; } = null!;

    public string AfiModelo { get; set; } = null!;

    public string AfiCodSerie { get; set; } = null!;

    public string AfiCodAgrup { get; set; } = null!;

    public string AfiMarca { get; set; } = null!;

    public decimal AfiUbiFisicaCod { get; set; }

    public string AfiUbiFisicaDes { get; set; } = null!;

    public decimal AfiResponsable { get; set; }

    public string AfiResponsableGl { get; set; } = null!;

    public short AfiUnidadCod { get; set; }

    public string AfiUnidadDes { get; set; } = null!;

    public int AfiCantidad { get; set; }

    public decimal PMonedaIdAdq { get; set; }

    public DateTime AfiFechaIngreso { get; set; }

    public DateTime AfiFechaAdq { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public string AfiRutProv { get; set; } = null!;

    public decimal AfiDctoDigitacion { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public double AfiValorBajaMoneda { get; set; }

    public double AfiValorCompra { get; set; }

    public decimal PAfiOpeDetId { get; set; }

    public string AfiDescripcionOpe { get; set; } = null!;

    public string AfiNumFactura { get; set; } = null!;

    public byte AfiEstado { get; set; }

    public string AfiEstadoDes { get; set; } = null!;

    public byte AfiEstFisico { get; set; }

    public string ConEstGlosa { get; set; } = null!;

    public byte AfiTipoCalculoCod { get; set; }

    public short AfiEjercicioInc { get; set; }

    public byte AfiPerMesInc { get; set; }

    public string AfiNomPeriodoInc { get; set; } = null!;

    public short AfiEjercicioInDep { get; set; }

    public byte AfiPerMesInDep { get; set; }

    public string AfiNomPeriodo { get; set; } = null!;

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

    public byte AfiUsaDepHoras { get; set; }

    public decimal AfiVuhorasOriginal { get; set; }

    public int AfiSvuhoras { get; set; }

    public int AfiSvuhorasReal { get; set; }

    public double AfiDepAcumEje { get; set; }

    public double AfiDepAcumTotal { get; set; }

    public double AfiTasacionInicial { get; set; }

    public double AfiValorNeto { get; set; }

    public int CreCodigo { get; set; }

    public string CreNombre { get; set; } = null!;

    public double AfiPorcentajeResp { get; set; }

    public int AfiTotalSgrupo { get; set; }

    public int AfiTotalGrupo { get; set; }

    public int AfiTotalUni { get; set; }

    public int AfiTotalDiv { get; set; }

    public int AfiTotalGneral { get; set; }

    public byte AfiStatus { get; set; }
}
