using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTTipoGasto
{
    public decimal TipGastoId { get; set; }

    public string TipGastoGlosa { get; set; } = null!;

    public byte TipGastoTipo { get; set; }

    public decimal PCtaId { get; set; }
}
