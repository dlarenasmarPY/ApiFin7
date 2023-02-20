using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTPaise
{
    public decimal PaisId { get; set; }

    public string PaisNombre { get; set; } = null!;

    public decimal PZonaId { get; set; }

    public decimal PPaisId { get; set; }

    public short PaisCodigoSii { get; set; }
}
