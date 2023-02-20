using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTUso
{
    public decimal PEmpId { get; set; }

    public short IdUso { get; set; }

    public string UsoNombre { get; set; } = null!;
}
