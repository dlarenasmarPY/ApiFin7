using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemTblAtribModelo
{
    public decimal RemAtrMid { get; set; }

    public decimal PRemTbMid { get; set; }

    public string AtrMnombre { get; set; } = null!;

    public string AtrMdescripcion { get; set; } = null!;

    public string AtrMnombreAcc { get; set; } = null!;

    public string? AtrMnombreHst { get; set; }

    public short AtrMorigenLargo { get; set; }

    public short AtrMorigenTipo { get; set; }

    public short AtrMorigenCantDec { get; set; }

    public byte AtrMindTraduccion { get; set; }

    public string? AtrMtblTraduccion { get; set; }

    public string? AtrMkeyTraduccion { get; set; }

    public string? AtrMforeingKey { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemTblModelo PRemTbM { get; set; } = null!;

    public virtual ICollection<RhuTRemConcepto> RhuTRemConceptos { get; } = new List<RhuTRemConcepto>();

    public virtual ICollection<RhuTRemConceptosPer> RhuTRemConceptosPers { get; } = new List<RhuTRemConceptosPer>();
}
