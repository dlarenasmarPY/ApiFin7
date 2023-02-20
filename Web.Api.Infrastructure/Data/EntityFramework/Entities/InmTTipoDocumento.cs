using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTTipoDocumento
{
    public short TdoId { get; set; }

    public string TdoGlosa { get; set; } = null!;
}
