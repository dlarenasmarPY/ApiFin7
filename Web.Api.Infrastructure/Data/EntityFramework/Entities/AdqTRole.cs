using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTRole
{
    public decimal RolId { get; set; }

    public string RolDes { get; set; } = null!;

    public byte RolIdParent { get; set; }

    public string IdRol { get; set; } = null!;

    public virtual ICollection<AdqTRolUsuarioEmp> AdqTRolUsuarioEmps { get; } = new List<AdqTRolUsuarioEmp>();
}
