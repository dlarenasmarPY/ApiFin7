using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTFinTotale
{
    public string CodOwner { get; set; } = null!;

    public double MontoLocalDebe { get; set; }

    public double MontoLocalHaber { get; set; }
}
