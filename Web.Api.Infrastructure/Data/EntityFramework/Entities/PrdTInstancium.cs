using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTInstancium
{
    public decimal InstanciaId { get; set; }

    public string InstanciaDes { get; set; } = null!;
}
