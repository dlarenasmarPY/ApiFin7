using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaAnotacione
{
    public decimal IdAnotacion { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal? PCtoId { get; set; }

    public short EjeAno { get; set; }

    public decimal PEmpId { get; set; }

    public string TipoAnotacion { get; set; } = null!;

    public string TipoCalificacion { get; set; } = null!;

    public double? NotaNumerica { get; set; }

    public decimal? PidNota { get; set; }

    public string OrigenAnotacion { get; set; } = null!;

    public decimal? PidEjecucion { get; set; }

    public string Anotacion { get; set; } = null!;

    public decimal PItmEstAnot { get; set; }

    public DateTime FechaAnotacion { get; set; }

    public string IndFirma { get; set; } = null!;

    public DateTime? FechaFirma { get; set; }

    public decimal? PFicPerIdEvaluador { get; set; }

    public decimal? PFicPerIdSupervisor { get; set; }

    public int? CreCodigo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTEvaParTipoAnotacion TipoAnotacionNavigation { get; set; } = null!;
}
