using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelPostulante
{
    public decimal IdPostulante { get; set; }

    public decimal PFicPerId { get; set; }

    public string CodEstadoPostulante { get; set; } = null!;

    public DateTime FecEstado { get; set; }

    public decimal PidCargoPostulante { get; set; }

    public decimal PidOrdenProceso { get; set; }

    public decimal PidOrdenProcesoEval { get; set; }

    public double PorRanking { get; set; }

    public string IndSeleccion { get; set; } = null!;

    public decimal PidSolicitudDetalle { get; set; }

    public string TipoFuenteReclutamiento { get; set; } = null!;

    public string GlosaObservacion { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTFicPersona PFicPer { get; set; } = null!;

    public virtual ICollection<RhuTSelCargoPostulante> RhuTSelCargoPostulantes { get; } = new List<RhuTSelCargoPostulante>();

    public virtual ICollection<RhuTSelEvaluaPostulante> RhuTSelEvaluaPostulantes { get; } = new List<RhuTSelEvaluaPostulante>();

    public virtual ICollection<RhuTSelHisPostulante> RhuTSelHisPostulantes { get; } = new List<RhuTSelHisPostulante>();

    public virtual ICollection<RhuTSelNotificacion> RhuTSelNotificacions { get; } = new List<RhuTSelNotificacion>();

    public virtual ICollection<RhuTSelRefPostulante> RhuTSelRefPostulantes { get; } = new List<RhuTSelRefPostulante>();
}
