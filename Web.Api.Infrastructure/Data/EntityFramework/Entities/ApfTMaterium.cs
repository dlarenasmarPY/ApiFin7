using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTMaterium
{
    public decimal TmatId { get; set; }

    public decimal PEmpId { get; set; }

    public byte TmatModulo { get; set; }

    public short TmatCodigo { get; set; }

    public string TmatNombre { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }
}
