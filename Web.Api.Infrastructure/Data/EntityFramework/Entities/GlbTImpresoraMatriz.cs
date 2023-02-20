using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTImpresoraMatriz
{
    public decimal ImpresoraMatrizId { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public string GlbCodImpresora { get; set; } = null!;

    public string GlbRutaImpresora { get; set; } = null!;

    public decimal PEmpId { get; set; }
}
