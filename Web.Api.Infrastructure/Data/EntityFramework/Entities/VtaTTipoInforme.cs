using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoInforme
{
    public decimal PEmpId { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string TivNombreRdl { get; set; } = null!;

    public string TivNombreReporte { get; set; } = null!;
}
