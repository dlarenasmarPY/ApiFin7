using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoBitacora
{
    public short BidOrigenDato { get; set; }

    public string BidGlosa { get; set; } = null!;
}
