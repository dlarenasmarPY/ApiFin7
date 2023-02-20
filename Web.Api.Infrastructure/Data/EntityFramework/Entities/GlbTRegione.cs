using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTRegione
{
    public byte RegCodigo { get; set; }

    public string RegNombre { get; set; } = null!;

    public decimal PPaisId { get; set; }
}
