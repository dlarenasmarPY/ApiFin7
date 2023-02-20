using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelTsolicitudDet
{
    public decimal IdSolicitudDetalle { get; set; }

    public decimal PidSolicitud { get; set; }

    public short CgoCodCargo { get; set; }

    public short CantVacantesSol { get; set; }

    public short CantVacantesCon { get; set; }

    public short CantVacantesReal { get; set; }

    public short CantVacantesAut { get; set; }

    public string GlosaObservacion { get; set; } = null!;

    public string CodEstadoSsolicitudDet { get; set; } = null!;

    public DateTime FecEstado { get; set; }

    public decimal PidOrdenProceso { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelTsolicitud PidSolicitudNavigation { get; set; } = null!;
}
