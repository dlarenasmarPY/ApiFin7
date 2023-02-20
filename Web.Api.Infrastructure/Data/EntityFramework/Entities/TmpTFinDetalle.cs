using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTFinDetalle
{
    public string CodOwner { get; set; } = null!;

    public double Cantidad { get; set; }

    public string CtaNombre { get; set; } = null!;

    public string MonGlosa { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public byte TauId { get; set; }

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }
}
