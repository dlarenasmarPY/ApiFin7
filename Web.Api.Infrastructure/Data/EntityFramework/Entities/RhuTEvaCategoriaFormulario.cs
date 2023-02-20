using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEvaCategoriaFormulario
{
    public decimal IdCategoriaFormulario { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PidFormulario { get; set; }

    public string TipoCategoria { get; set; } = null!;

    public DateTime FecVigencia { get; set; }

    public decimal PItmEstCat { get; set; }

    public DateTime FechaObsolecencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTEvaFormulario PidFormularioNavigation { get; set; } = null!;
}
