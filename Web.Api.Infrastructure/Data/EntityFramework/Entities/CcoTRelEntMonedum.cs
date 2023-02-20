using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRelEntMonedum
{
    public decimal PEntCcoId { get; set; }

    public decimal PMonedaId { get; set; }

    public string RelEntMon { get; set; } = null!;
}
