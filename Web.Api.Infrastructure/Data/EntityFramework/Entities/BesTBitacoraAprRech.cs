using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class BesTBitacoraAprRech
{
    public decimal BitId { get; set; }

    public decimal PEmpId { get; set; }

    public int CorrLogtNum { get; set; }

    public string Observaciones { get; set; } = null!;

    public DateTime FechaIngreso { get; set; }
}
