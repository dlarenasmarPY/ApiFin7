using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaFormulario
{
    public decimal IdFormulario { get; set; }

    public string CodFormulario { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public DateTime FecVigencia { get; set; }

    public decimal PItmEstForm { get; set; }

    public DateTime? FecObsolecencia { get; set; }

    public string? ObjetivoEvaluacion { get; set; }

    public string? InstruccionEvaluacion { get; set; }

    public string? TipoCalificacion { get; set; }

    public string IdProcesoNegocio { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTEvaCategoriaFormulario> RhuTEvaCategoriaFormularios { get; } = new List<RhuTEvaCategoriaFormulario>();

    public virtual ICollection<RhuTEvaFormularioFactor> RhuTEvaFormularioFactors { get; } = new List<RhuTEvaFormularioFactor>();

    public virtual ICollection<RhuTEvaFormularioItem> RhuTEvaFormularioItems { get; } = new List<RhuTEvaFormularioItem>();
}
