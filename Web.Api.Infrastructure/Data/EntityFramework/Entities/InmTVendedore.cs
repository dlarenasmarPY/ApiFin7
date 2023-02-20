using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTVendedore
{
    public decimal PEmpId { get; set; }

    public int VenId { get; set; }

    public string VenNombre { get; set; } = null!;

    public string VenUserName { get; set; } = null!;
}
