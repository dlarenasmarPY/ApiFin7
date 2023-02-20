using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTRutaArchivo
{
    public decimal RutaArchivoId { get; set; }

    public string IdProcesoNegocio { get; set; } = null!;

    public string RutaArchivoRuta { get; set; } = null!;
}
