using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieConvenio
{
    public decimal BieConvId { get; set; }

    public decimal NumBieConv { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public DateTime FecVigenciaDesde { get; set; }

    public DateTime FecVigenciaHasta { get; set; }

    public string GlosaBieConv { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public decimal ValConvenio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTBieConveniosSdo> RhuTBieConveniosSdos { get; } = new List<RhuTBieConveniosSdo>();

    public virtual ICollection<RhuTBieSociosConv> RhuTBieSociosConvs { get; } = new List<RhuTBieSociosConv>();
}
