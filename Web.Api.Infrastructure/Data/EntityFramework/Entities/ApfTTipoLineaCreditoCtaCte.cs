using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTTipoLineaCreditoCtaCte
{
    public decimal PTlcId { get; set; }

    public int InstCod { get; set; }

    public string CodCtaCteBco { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public double MontoAprobado { get; set; }

    public double TasaInteres { get; set; }

    public byte TipoTasa { get; set; }
}
