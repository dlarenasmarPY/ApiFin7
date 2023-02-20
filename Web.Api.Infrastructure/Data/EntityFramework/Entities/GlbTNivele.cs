using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTNivele
{
    public byte NivId { get; set; }

    public string NivGlosa { get; set; } = null!;
}
