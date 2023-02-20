using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTInstruccionCobranza
{
    public byte InsCcoCod { get; set; }

    public string InsCcoGlosa { get; set; } = null!;
}
