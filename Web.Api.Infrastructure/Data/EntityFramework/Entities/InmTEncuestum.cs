using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTEncuestum
{
    public short PreguntaId { get; set; }

    public string PreguntaGlosa { get; set; } = null!;
}
