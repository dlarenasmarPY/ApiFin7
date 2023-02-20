using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCotizacionCabGlosa
{
    public decimal CotizCabGlosaId { get; set; }

    public decimal PCotizCabId { get; set; }

    public decimal PGlosaId { get; set; }

    public string GlosaDes { get; set; } = null!;

    public virtual AdqTCotizacionCab PCotizCab { get; set; } = null!;

    public virtual AdqTGlosa PGlosa { get; set; } = null!;
}
