using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTAfiDistribUgedet1Ifr
{
    public string CodOwner { get; set; } = null!;

    public decimal PCodigoBienId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public string DivGlosa { get; set; } = null!;

    public short UniCodigo { get; set; }

    public short AfiGrupoCod { get; set; }

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public double AfiPorcentajeResp { get; set; }

    public string AfiDescripcion { get; set; } = null!;

    public byte AfiTipoCalculoCod { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public double AfiValorNeto { get; set; }

    public decimal PPcrId { get; set; }

    public short ClaCreNivel1 { get; set; }

    public short ClaCreNivel2 { get; set; }

    public short ClaCreNivel3 { get; set; }

    public short ClaCreNivel4 { get; set; }

    public short ClaCreNivel5 { get; set; }

    public short ClaCreNivel6 { get; set; }

    public short ClaCreNivel7 { get; set; }

    public decimal PCreId { get; set; }

    public byte ClaCreNodoNivel { get; set; }

    public string ClaCreNodoNombre { get; set; } = null!;

    public string AfiGlosaNivelUge { get; set; } = null!;

    public int ClaCreNodoCodigoAlt { get; set; }

    public string ClaCreRespCodigo { get; set; } = null!;

    public string ClaCreRespNombre { get; set; } = null!;

    public byte AfiUgeUsaDivCodigo { get; set; }

    public decimal AfiCorrelativo { get; set; }

    public int PClaIdentity { get; set; }

    public byte AfiStatus { get; set; }
}
