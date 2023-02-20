using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTConInfExcel
{
    public decimal ConInfId { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string ConInfUsuario { get; set; } = null!;

    public string ConInfNomInforme { get; set; } = null!;

    public DateTime ConInfFecha { get; set; }

    public string ConInfValorParametro { get; set; } = null!;
}
