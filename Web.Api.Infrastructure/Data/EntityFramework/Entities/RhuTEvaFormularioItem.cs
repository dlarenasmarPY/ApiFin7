using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaFormularioItem
{
    public decimal IdFormularioItem { get; set; }

    public decimal PidFormulario { get; set; }

    public decimal PidItem { get; set; }

    public decimal PidFactor { get; set; }

    public double? PesoPorcentual { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTEvaFormulario PidFormularioNavigation { get; set; } = null!;

    public virtual RhuTEvaItemEvaluacion PidItemNavigation { get; set; } = null!;
}
