using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaEjecucion
{
    public decimal IdEjecucion { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PCtoId { get; set; }

    public string TipoProcesoEvaluacion { get; set; } = null!;

    public decimal? PidCalendario { get; set; }

    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public short? SeqProceso { get; set; }

    public string? TipoCategoria { get; set; }

    public DateTime FechaEvaluacion { get; set; }

    public decimal PItmEstEva { get; set; }

    public short? CgoCodCargo { get; set; }

    public int? CreCodigo { get; set; }

    public short? LugCodigo { get; set; }

    public decimal? PFicPerIdEvaluador { get; set; }

    public decimal? PFicPerIdSupervisor { get; set; }

    public decimal PidFormulario { get; set; }

    public decimal TotalNotasFactores { get; set; }

    public decimal? TotalNotasFactoresApe { get; set; }

    public string IndFirma { get; set; } = null!;

    public DateTime? FechaFirma { get; set; }

    public string? IndApelacion { get; set; }

    public DateTime? FechaFirmaApelacion { get; set; }

    public string? ObservacionEvaluacion { get; set; }

    public string? CompromisoEvaluacion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTEvaEjecucionFactor> RhuTEvaEjecucionFactors { get; } = new List<RhuTEvaEjecucionFactor>();

    public virtual ICollection<RhuTEvaEjecucionItem> RhuTEvaEjecucionItems { get; } = new List<RhuTEvaEjecucionItem>();
}
