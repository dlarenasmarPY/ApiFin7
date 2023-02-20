using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DmLogTParametrosCarga
{
    public DateTime? FechaIni { get; set; }

    public DateTime? FechaFin { get; set; }

    public int? PlanProd { get; set; }

    public int? EmpId { get; set; }
}
