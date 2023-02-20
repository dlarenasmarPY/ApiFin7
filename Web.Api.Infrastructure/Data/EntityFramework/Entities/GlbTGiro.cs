using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTGiro
{
    public int GirCod { get; set; }

    public string GirGlosa { get; set; } = null!;

    public string GirGlosa255 { get; set; } = null!;
}
