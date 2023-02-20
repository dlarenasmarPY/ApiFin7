using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEscenario
{
    public byte EscenarioCod { get; set; }

    public string EscenarioDes { get; set; } = null!;

    public decimal PCtaIdPuente { get; set; }

    public decimal PCtaIdCierre { get; set; }

    public decimal PCtaIdAjusAuto { get; set; }
}
