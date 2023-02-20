using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemInformesTit
{
    public decimal PEmpId { get; set; }

    public decimal PClmInfId { get; set; }

    public string InfCtituloCol { get; set; } = null!;
}
