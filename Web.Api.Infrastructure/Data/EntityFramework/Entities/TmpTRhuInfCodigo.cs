using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuInfCodigo
{
    public string CodOwner { get; set; } = null!;

    public string TipoId { get; set; } = null!;

    public decimal PIdParametro { get; set; }
}
