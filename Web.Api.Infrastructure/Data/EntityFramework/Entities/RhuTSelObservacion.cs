using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelObservacion
{
    public decimal IdObservacion { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string TipoObservacion { get; set; } = null!;

    public decimal PidSolicitud { get; set; }

    public decimal PidSolicitudDetalle { get; set; }

    public decimal PidOrdenProceso { get; set; }

    public decimal PidPostulante { get; set; }

    public decimal PidEvaluacion { get; set; }

    public DateTime FecObservacion { get; set; }

    public string GlosaObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelTsolicitud PidSolicitudNavigation { get; set; } = null!;
}
