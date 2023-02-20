using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemProcesosCon
{
    public string CodOwner { get; set; } = null!;

    public decimal PProcConcId { get; set; }

    public int CprPrioridadCalc { get; set; }

    public int XCprPrioridadCalc { get; set; }
}
