using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTCfgEspeciale
{
    public decimal PEmpId { get; set; }

    public string ClienteId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Glosa { get; set; } = null!;
}
