using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTValoresMonedum
{
    public decimal PMonedaId { get; set; }

    public decimal PPerId { get; set; }

    public decimal ValMonProyectado { get; set; }

    public decimal ValMonReal { get; set; }
}
