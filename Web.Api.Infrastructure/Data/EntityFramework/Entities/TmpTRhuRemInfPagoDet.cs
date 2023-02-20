using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemInfPagoDet
{
    public string CodOwner { get; set; } = null!;

    public decimal PInfPagId { get; set; }

    public decimal PConcPerId { get; set; }

    public string DetCalcGlosa { get; set; } = null!;
}
