using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTmpEmpresa
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public byte IndSeleccion { get; set; }
}
