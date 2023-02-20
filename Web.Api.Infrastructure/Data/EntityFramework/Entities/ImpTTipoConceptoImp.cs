using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTTipoConceptoImp
{
    public decimal TipoConceptoImpId { get; set; }

    public string TipoConceptoImpGlosa { get; set; } = null!;
}
