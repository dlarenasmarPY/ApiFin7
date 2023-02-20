using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParInterfazDet
{
    public decimal IcFcolSeqId { get; set; }

    public decimal PIcFseqId { get; set; }

    public decimal PDicId { get; set; }

    public byte IcFcolTipoCol { get; set; }

    public short IcFcolLargo { get; set; }

    public short IcFcolPosIni { get; set; }

    public short IcFcolPosFin { get; set; }

    public byte IcFcolDecimal { get; set; }

    public string IcFcolFormFecha { get; set; } = null!;

    public decimal PTabParId { get; set; }

    public short IcFcolOrden { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParDicColumna PDic { get; set; } = null!;

    public virtual RhuTParInterfaz PIcFseq { get; set; } = null!;

    public virtual RhuTParTabla PTabPar { get; set; } = null!;
}
