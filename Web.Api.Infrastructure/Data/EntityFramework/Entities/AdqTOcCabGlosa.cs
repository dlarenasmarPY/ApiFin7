using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcCabGlosa
{
    public decimal OcCabGlosaId { get; set; }

    public decimal POcCabId { get; set; }

    public decimal PGlosaId { get; set; }

    public string GlosaDes { get; set; } = null!;

    public virtual AdqTGlosa PGlosa { get; set; } = null!;

    public virtual AdqTOcCab POcCab { get; set; } = null!;
}
