using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTMotivosBloqueo
{
    public decimal MotivoBloqueoId { get; set; }

    public string MotivoBloqueoDes { get; set; } = null!;
}
