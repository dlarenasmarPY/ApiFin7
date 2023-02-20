using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelParActividad
{
    public short CodActividad { get; set; }

    public string DescActividad { get; set; } = null!;

    public string TipoActividad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTSelParActividadInicial> RhuTSelParActividadInicials { get; } = new List<RhuTSelParActividadInicial>();
}
