using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTRolUsuarioCentro
{
    public decimal RolUsuarioCentroId { get; set; }

    public decimal PRolUsuarioEmpId { get; set; }

    public decimal PCreId { get; set; }

    public double UserMontoMax { get; set; }

    public decimal PMonedaId { get; set; }

    public virtual ConTCentrosResp PCre { get; set; } = null!;

    public virtual AdqTRolUsuarioEmp PRolUsuarioEmp { get; set; } = null!;
}
