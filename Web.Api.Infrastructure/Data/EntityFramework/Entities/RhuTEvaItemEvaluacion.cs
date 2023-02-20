using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaItemEvaluacion
{
    public decimal IdItem { get; set; }

    public string CodItem { get; set; } = null!;

    public decimal PidFactor { get; set; }

    public string GlosaItem { get; set; } = null!;

    public string TipoCalificacion { get; set; } = null!;

    public double PesoPorcentualRef { get; set; }

    public string? ObjetivoEvaluacion { get; set; }

    public string? InstruccionEvaluacion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTEvaFormularioItem> RhuTEvaFormularioItems { get; } = new List<RhuTEvaFormularioItem>();
}
