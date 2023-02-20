using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEmpresaVendedor
{
    public decimal PEmpId { get; set; }

    public string FldUserCode { get; set; } = null!;
}
