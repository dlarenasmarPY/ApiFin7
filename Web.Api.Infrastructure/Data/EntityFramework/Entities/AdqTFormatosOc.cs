using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTFormatosOc
{
    public decimal PEmpId { get; set; }

    public int NroReporte { get; set; }

    public string NombreReporte { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public byte IndTipoImpresion { get; set; }

    public byte DivCodigo { get; set; }

    public string RutaImagenFirma { get; set; } = null!;
}
