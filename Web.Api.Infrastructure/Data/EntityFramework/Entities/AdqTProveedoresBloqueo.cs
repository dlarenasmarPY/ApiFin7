using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTProveedoresBloqueo
{
    public decimal IdProvBloqueo { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PMotivoBloqueoId { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecIngReg { get; set; }
}
