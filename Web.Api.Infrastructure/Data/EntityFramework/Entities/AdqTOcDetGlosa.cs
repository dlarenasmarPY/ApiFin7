using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTOcDetGlosa
{
    public decimal OcDetGlosaId { get; set; }

    public decimal POcDetId { get; set; }

    public decimal PGlosaId { get; set; }

    public string GlosaDes { get; set; } = null!;

    public virtual AdqTGlosa PGlosa { get; set; } = null!;

    public virtual AdqTOcDet POcDet { get; set; } = null!;
}
