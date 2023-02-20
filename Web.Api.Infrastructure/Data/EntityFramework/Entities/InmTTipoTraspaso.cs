using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTipoTraspaso
{
    public short TraspasoId { get; set; }

    public string TraspasoGlosa { get; set; } = null!;
}
