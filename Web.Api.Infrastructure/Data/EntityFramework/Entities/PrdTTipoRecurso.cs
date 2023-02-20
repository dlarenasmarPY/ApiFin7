using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTipoRecurso
{
    public byte TipoRecursoCod { get; set; }

    public string TipoRecursoDes { get; set; } = null!;
}
