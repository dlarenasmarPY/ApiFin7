using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelParActividadInicial
{
    public decimal IdActividadInicial { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public short CodActividad { get; set; }

    public short CodActividadPrevia { get; set; }

    public string UserControl { get; set; } = null!;

    public string CodEstadoIniActividad { get; set; } = null!;

    public short NumPrioridad { get; set; }

    public short NumNivel { get; set; }

    public short CodActividadPadre { get; set; }

    public string IndModificaPendiente { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelParActividad CodActividadNavigation { get; set; } = null!;

    public virtual ICollection<RhuTSelActividad> RhuTSelActividads { get; } = new List<RhuTSelActividad>();
}
