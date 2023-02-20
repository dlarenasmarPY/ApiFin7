using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTAuditoriaVd
{
    public decimal AuditoriaId { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime MonVdmFec { get; set; }

    public double MonVdmValor1 { get; set; }

    public double MonVdmDifCm { get; set; }

    public string AudAccion { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;
}
