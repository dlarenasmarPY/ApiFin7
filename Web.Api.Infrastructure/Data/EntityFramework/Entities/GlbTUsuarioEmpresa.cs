using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTUsuarioEmpresa
{
    public string FldUserCode { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public decimal EmpIdDefault { get; set; }
}
