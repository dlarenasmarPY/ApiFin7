using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTAtributosUsuario
{
    public short AtributoId { get; set; }

    public string AtributoGlosa { get; set; } = null!;
}
