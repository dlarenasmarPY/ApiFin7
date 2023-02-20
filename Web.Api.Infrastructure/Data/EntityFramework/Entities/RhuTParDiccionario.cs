using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParDiccionario
{
    public decimal DtoDicId { get; set; }

    public string DtoDicNomCol { get; set; } = null!;

    public decimal PDtoDicTipColId { get; set; }

    public string DtoDicTabOri { get; set; } = null!;

    public string DtoDicAtribOri { get; set; } = null!;

    public byte DtoDicIndTrad { get; set; }

    public string DtoDicTabTrad { get; set; } = null!;

    public string DtoDicAtribTrad { get; set; } = null!;

    public string DtoDicJoinTrad { get; set; } = null!;

    public string DtoDicValTrad { get; set; } = null!;

    public string DtoDicDesTrad { get; set; } = null!;

    public byte DtoDicUsoFiltro { get; set; }

    public decimal PDtoDicTipFiltroId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParItem PDtoDicTipCol { get; set; } = null!;

    public virtual RhuTParItem PDtoDicTipFiltro { get; set; } = null!;

    public virtual ICollection<RhuTCtoDatosCertif> RhuTCtoDatosCertifs { get; } = new List<RhuTCtoDatosCertif>();
}
