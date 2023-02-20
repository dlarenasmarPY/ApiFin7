using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCausalDevolucion
{
    public short CausalId { get; set; }

    public string CausalGlosa { get; set; } = null!;
}
