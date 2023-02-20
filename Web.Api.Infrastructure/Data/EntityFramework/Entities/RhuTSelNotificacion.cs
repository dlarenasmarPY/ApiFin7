using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelNotificacion
{
    public decimal IdNotificacion { get; set; }

    public string TipoNotificacion { get; set; } = null!;

    public DateTime FecNotificacion { get; set; }

    public decimal PidPostulante { get; set; }

    public decimal PidEtapaEvaluacion { get; set; }

    public decimal PidOrdenProceso { get; set; }

    public decimal PMedioAvisoId { get; set; }

    public string GlosaAviso { get; set; } = null!;

    public string IndContinuidad { get; set; } = null!;

    public string GlosaObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelPostulante PidPostulanteNavigation { get; set; } = null!;
}
