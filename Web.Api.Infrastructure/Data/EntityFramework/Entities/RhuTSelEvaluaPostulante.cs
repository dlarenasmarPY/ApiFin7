using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelEvaluaPostulante
{
    public decimal IdEtapaEvaluacion { get; set; }

    public decimal PidPostulante { get; set; }

    public decimal PidEvaluacion { get; set; }

    public decimal PidOrdenProceso { get; set; }

    public string IndFormulario { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PidEjecucion { get; set; }

    public string CodEstadoEvaluacion { get; set; } = null!;

    public DateTime FecEstado { get; set; }

    public DateTime FecEstimadaTermino { get; set; }

    public DateTime FecEvaluacion { get; set; }

    public short HoraEvaluacion { get; set; }

    public decimal PItmLugarEvaId { get; set; }

    public decimal PCoordinadorSelId { get; set; }

    public string IndObligatorio { get; set; } = null!;

    public string IndCitacion { get; set; } = null!;

    public string IndAsistencia { get; set; } = null!;

    public string IndResultado { get; set; } = null!;

    public string TipoCalificacion { get; set; } = null!;

    public string CodNota { get; set; } = null!;

    public double PorCalificacion { get; set; }

    public DateTime FecEvaluacionReal { get; set; }

    public short HoraEvaluacionReal { get; set; }

    public decimal PItmLugarEvaRealId { get; set; }

    public decimal PCoordinadorSelRealId { get; set; }

    public string IndNotificacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelEvaluacion PidEvaluacionNavigation { get; set; } = null!;

    public virtual RhuTSelPostulante PidPostulanteNavigation { get; set; } = null!;
}
