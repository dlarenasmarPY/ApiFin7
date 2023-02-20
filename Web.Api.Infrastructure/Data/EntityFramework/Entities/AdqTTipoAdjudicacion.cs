using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTTipoAdjudicacion
{
    public decimal TipoAdjudicaId { get; set; }

    public string TipoAdjudicaDes { get; set; } = null!;
}
