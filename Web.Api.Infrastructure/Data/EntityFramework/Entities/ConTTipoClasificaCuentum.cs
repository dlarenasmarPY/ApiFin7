using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTTipoClasificaCuentum
{
    public byte TccId { get; set; }

    public string TccGlosa { get; set; } = null!;
}
