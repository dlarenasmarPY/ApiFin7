using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTTipoIntere
{
    public byte TipoInteres { get; set; }

    public string GlosaInteres { get; set; } = null!;
}
