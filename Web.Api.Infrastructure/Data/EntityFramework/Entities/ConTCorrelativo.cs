using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCorrelativo
{
    public decimal CorId { get; set; }

    public byte CorTipo { get; set; }

    public decimal PEmpId { get; set; }

    public short CorCodigo { get; set; }

    public string CorGlosa { get; set; } = null!;
}
