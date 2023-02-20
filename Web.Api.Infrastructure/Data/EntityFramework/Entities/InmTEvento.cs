using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTEvento
{
    public short EventoId { get; set; }

    public string EventoGlosa { get; set; } = null!;
}
