using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTAsocUsuMoneda
{
    public string Usuario { get; set; } = null!;

    public decimal PMonedaId { get; set; }
}
