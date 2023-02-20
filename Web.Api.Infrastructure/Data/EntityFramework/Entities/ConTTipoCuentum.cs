using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTTipoCuentum
{
    public byte TctId { get; set; }

    public string TctGlosa { get; set; } = null!;
}
