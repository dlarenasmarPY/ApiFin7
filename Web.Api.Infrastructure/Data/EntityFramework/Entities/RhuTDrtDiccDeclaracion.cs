using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTDrtDiccDeclaracion
{
    public decimal DrtDicId { get; set; }

    public string DrtDicCampoNom { get; set; } = null!;

    public string DrtDicCampoDescr { get; set; } = null!;

    public byte DrtDicIndTipCampo { get; set; }

    public string? DrtDicTblAlias { get; set; }

    public string? DrtDicTblSql { get; set; }

    public decimal DrtDicTipDato { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string DrtDicUso { get; set; } = null!;

    public virtual ICollection<RhuTDrtFormatoDecl> RhuTDrtFormatoDecls { get; } = new List<RhuTDrtFormatoDecl>();
}
