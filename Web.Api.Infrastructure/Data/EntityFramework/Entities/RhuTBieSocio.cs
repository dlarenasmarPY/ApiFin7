using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieSocio
{
    public decimal BieSocId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime FecVigencia { get; set; }

    public DateTime FecExpiracion { get; set; }

    public string GlosaMotivo { get; set; } = null!;

    public string BieInfSdo { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTBieApertura> RhuTBieAperturas { get; } = new List<RhuTBieApertura>();

    public virtual ICollection<RhuTBieSociosConv> RhuTBieSociosConvs { get; } = new List<RhuTBieSociosConv>();

    public virtual ICollection<RhuTBieSociosTope> RhuTBieSociosTopes { get; } = new List<RhuTBieSociosTope>();

    public virtual ICollection<RhuTBieSolicitude> RhuTBieSolicitudes { get; } = new List<RhuTBieSolicitude>();
}
