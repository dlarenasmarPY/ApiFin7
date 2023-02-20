using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTModalidadCobranza
{
    public byte ModCcoCod { get; set; }

    public string ModCcoGlosa { get; set; } = null!;
}
