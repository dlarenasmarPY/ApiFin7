using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTFormula
{
    public byte AfiFormulaCod { get; set; }

    public string AfiFormulaDes { get; set; } = null!;
}
