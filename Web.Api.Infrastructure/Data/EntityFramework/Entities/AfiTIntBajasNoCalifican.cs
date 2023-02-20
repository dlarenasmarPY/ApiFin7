using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTIntBajasNoCalifican
{
    public decimal IntBajasNoClaId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short EjeAno { get; set; }

    public byte PerMes { get; set; }

    public decimal PCodigoBienId { get; set; }

    public byte AfiEstado { get; set; }

    public byte AfiEstadoBajaCod { get; set; }

    public int AfiFolio { get; set; }

    public decimal AfiOpeCod { get; set; }

    public double AfiValorBaja { get; set; }

    public double AfiValorBajaVenta { get; set; }

    public string AfiDctoLegal { get; set; } = null!;

    public double AfiPorcentajeBaja { get; set; }

    public DateTime AfiFechaIngBaja { get; set; }

    public DateTime AfiFechaAprBaja { get; set; }

    public DateTime AfiFechaEjecBaja { get; set; }

    public decimal PCabOpeId { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public byte AfiContabiliza { get; set; }

    public string AfiCodSerie { get; set; } = null!;

    public string AfiCodAgrup { get; set; } = null!;

    public string AfiCodAnterior { get; set; } = null!;

    public string AfiDescripcion { get; set; } = null!;

    public DateTime AfiFechaIngreso { get; set; }

    public decimal AfiUbiFisicaCod { get; set; }

    public decimal PCodigoBienIdAlt { get; set; }

    public string NombreArchivoCarga { get; set; } = null!;

    public short AfiEjeAnoCarga { get; set; }

    public byte AfiPerMesCarga { get; set; }

    public int Linea { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
