using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTipoDesistimiento
{
    public short TipoDesId { get; set; }

    public string TipoDesGlosa { get; set; } = null!;
}
