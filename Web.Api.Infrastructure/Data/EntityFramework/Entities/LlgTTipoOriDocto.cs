using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTTipoOriDocto
{
    public short TipOriDoctoCod { get; set; }

    public string TipOriDoctoGlosa { get; set; } = null!;
}
