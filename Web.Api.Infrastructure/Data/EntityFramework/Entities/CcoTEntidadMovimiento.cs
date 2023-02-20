using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTEntidadMovimiento
{
    public decimal EntMovCcoId { get; set; }

    public decimal PEntCcoId { get; set; }

    public byte TipMovCcoCod { get; set; }

    public string EntMovCcoInfCod { get; set; } = null!;

    public string EntMovCcoInfGlosa { get; set; } = null!;

    public byte EntMovCcoIndIngEgr { get; set; }

    public decimal PCtaId { get; set; }
}
