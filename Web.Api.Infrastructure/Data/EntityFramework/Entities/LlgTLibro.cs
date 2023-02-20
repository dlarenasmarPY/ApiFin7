using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTLibro
{
    public byte SisCodOri { get; set; }

    public short LblCod { get; set; }

    public string LblGlosa { get; set; } = null!;
}
