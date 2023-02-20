using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTAfiInfPorBccosto
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

    public string AfiGrupoDes { get; set; } = null!;

    public short AfiSubGrpCod { get; set; }

    public string AfiSubGrpDes { get; set; } = null!;

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public string AfiDescripcion { get; set; } = null!;

    public string AfiCodAnterior { get; set; } = null!;

    public string AfiCodBarraBien { get; set; } = null!;

    public decimal PEntIdResp { get; set; }

    public string EntRutResp { get; set; } = null!;

    public string AfiResponsableGl { get; set; } = null!;

    public decimal AfiUbiFisicaCod { get; set; }

    public string AfiUbiFisicaDes { get; set; } = null!;

    public short AfiUnidadCod { get; set; }

    public string AfiUnidadDes { get; set; } = null!;

    public DateTime AfiFechaAdq { get; set; }

    public DateTime AfiFechaIngreso { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public DateTime AfiFechaInventario { get; set; }

    public string AfiNumFactura { get; set; } = null!;

    public decimal PEntIdProv { get; set; }

    public string AfiRutProv { get; set; } = null!;

    public byte AfiEstado { get; set; }

    public string AfiEstadoDes { get; set; } = null!;

    public decimal PCreId { get; set; }

    public int CreCodigo { get; set; }

    public string CreNombre { get; set; } = null!;

    public double AfiPorcentajeResp { get; set; }

    public double AfiValorAdq { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public double AfiValorActivo { get; set; }

    public double AfiDepAcumTotal { get; set; }

    public double AfiValorNeto { get; set; }

    public decimal PAfiOpeDetId { get; set; }

    public string AfiDescripcionOpe { get; set; } = null!;

    public byte AfiStatus { get; set; }
}
