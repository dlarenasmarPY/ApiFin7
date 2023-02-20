using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParMoneda
{
    public decimal MdaId { get; set; }

    public string MdaGlosa { get; set; } = null!;

    public string MdaSimbolo { get; set; } = null!;

    public byte MdaIndUf { get; set; }

    public byte MdaIndUtm { get; set; }

    public byte MdaIndPct { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PConcRemId { get; set; }

    public byte MdaIndUso { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTApvcAfiliado> RhuTApvcAfiliados { get; } = new List<RhuTApvcAfiliado>();

    public virtual ICollection<RhuTApvcEmpresa> RhuTApvcEmpresas { get; } = new List<RhuTApvcEmpresa>();

    public virtual ICollection<RhuTCtoAfiliacionVol> RhuTCtoAfiliacionVols { get; } = new List<RhuTCtoAfiliacionVol>();

    public virtual ICollection<RhuTCtoRetJudPago> RhuTCtoRetJudPagos { get; } = new List<RhuTCtoRetJudPago>();

    public virtual ICollection<RhuTFicAntImponible> RhuTFicAntImponibles { get; } = new List<RhuTFicAntImponible>();
}
