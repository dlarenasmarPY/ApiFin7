using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTFnqCausale
{
    public decimal FnqCauId { get; set; }

    public short FnqCauArticulo { get; set; }

    public short FnqCauNumero { get; set; }

    public string FnqCauLetra { get; set; } = null!;

    public string FnqCauGlosaArt { get; set; } = null!;

    public string FnqCauGlosaNro { get; set; } = null!;

    public string FnqCauGlosaLet { get; set; } = null!;

    public string FnqCauIndLeg { get; set; } = null!;

    public string FnqCauIndConv { get; set; } = null!;

    public string FnqCauIndVol { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTApvcLegale> RhuTApvcLegales { get; } = new List<RhuTApvcLegale>();

    public virtual ICollection<RhuTFnqSolicitudDet> RhuTFnqSolicitudDets { get; } = new List<RhuTFnqSolicitudDet>();
}
