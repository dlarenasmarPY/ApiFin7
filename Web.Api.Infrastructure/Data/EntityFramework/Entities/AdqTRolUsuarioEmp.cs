using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTRolUsuarioEmp
{
    public decimal RolUsuarioEmpId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PRolId { get; set; }

    public string IdUsuario { get; set; } = null!;

    public double UserMontoMax { get; set; }

    public decimal PMonedaId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public virtual ICollection<AdqTRolUsuarioCentro> AdqTRolUsuarioCentros { get; } = new List<AdqTRolUsuarioCentro>();

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual GlbTMoneda PMoneda { get; set; } = null!;

    public virtual AdqTRole PRol { get; set; } = null!;
}
