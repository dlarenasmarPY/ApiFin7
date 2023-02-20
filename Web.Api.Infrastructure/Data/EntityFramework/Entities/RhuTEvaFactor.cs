using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaFactor
{
    public decimal IdFactor { get; set; }

    public string CodFactor { get; set; } = null!;

    public string GlosaFactor { get; set; } = null!;

    public double PesoPorcentualRef { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ICollection<RhuTEvaFormularioFactor> RhuTEvaFormularioFactors { get; } = new List<RhuTEvaFormularioFactor>();
}
