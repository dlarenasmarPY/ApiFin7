using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTAfiTinformeAdicion
{
    public string CodOwner { get; set; } = null!;

    public decimal PDatContId { get; set; }

    public decimal PCodigoBienId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short AfiGrupoCod { get; set; }

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public string DivGlosa { get; set; } = null!;

    public string UniNombre { get; set; } = null!;

    public string AfiGrupoDes { get; set; } = null!;

    public string AfiDescripcion { get; set; } = null!;

    public string AfiCodAnterior { get; set; } = null!;

    public decimal AfiUbiFisicaCod { get; set; }

    public string AfiUbiFisicaDes { get; set; } = null!;

    public int AfiFolio { get; set; }

    public byte AfiTipoAdicion { get; set; }

    public byte PerMes { get; set; }

    public string PerGlosa { get; set; } = null!;

    public string AfiGlosa { get; set; } = null!;

    public byte AfiContabiliza { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public int CreCodigo { get; set; }

    public string CreNombre { get; set; } = null!;

    public double AfiPorcentajeResp { get; set; }

    public double AfiValorAdqui { get; set; }

    public int DocLinea { get; set; }

    public byte AfiStatus { get; set; }
}
