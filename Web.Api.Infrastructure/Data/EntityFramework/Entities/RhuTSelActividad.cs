using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelActividad
{
    public decimal IdActividad { get; set; }

    public decimal PIdActividadInicial { get; set; }

    public decimal PidOrdenProceso { get; set; }

    public string CodEstadoActividad { get; set; } = null!;

    public DateTime FecEstado { get; set; }

    public string IndicadorEstado { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelParActividadInicial PIdActividadInicialNavigation { get; set; } = null!;

    public virtual RhuTSelOrdenProceso PidOrdenProcesoNavigation { get; set; } = null!;
}
