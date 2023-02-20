using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTTipoLineaCredito
{
    public decimal TlcId { get; set; }

    public decimal PEmpId { get; set; }

    public short TlcCodigo { get; set; }

    public string TlcNombre { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }
}
