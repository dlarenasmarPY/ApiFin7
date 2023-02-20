using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemConceptosPer
{
    public decimal ConcPerId { get; set; }

    public decimal PConcRemId { get; set; }

    public DateTime CpeFecIniVigencia { get; set; }

    public short CpeEstado { get; set; }

    public DateTime CpeFecTerVigencia { get; set; }

    public string CnRtipoAplicabilidad { get; set; } = null!;

    public string CpeFormula { get; set; } = null!;

    public decimal? CpeOriDatoAtrMid { get; set; }

    public decimal? CpeRefAplicTbMid { get; set; }

    public byte CpeIndUsoPermte { get; set; }

    public byte CpeIndUsoMovtoMes { get; set; }

    public string CpeTopeTipo { get; set; } = null!;

    public double CpeTopeValor { get; set; }

    public decimal? CpeTopeConcRemId { get; set; }

    public int CpeTipoAjuste { get; set; }

    public byte CpeIndHabLiquido { get; set; }

    public byte CpeHabLiquidoUso { get; set; }

    public byte CpeHabLiquidoRec { get; set; }

    public byte CpeIndGrabacion { get; set; }

    public byte CpeIndCentralizacion { get; set; }

    public decimal? CpeBaseImprConcId { get; set; }

    public decimal? CpeReliqDesdePerId { get; set; }

    public decimal? CpeReliqHastaPerId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte CpeIndConcepto { get; set; }

    public byte CpeIndAcumula { get; set; }

    public string CpeGlosa { get; set; } = null!;

    public virtual RhuTRemTblAtribModelo? CpeOriDatoAtrM { get; set; }

    public virtual RhuTRemTblModelo? CpeRefAplicTbM { get; set; }

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual ICollection<RhuTRemConceptosTot> RhuTRemConceptosTots { get; } = new List<RhuTRemConceptosTot>();
}
