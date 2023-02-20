using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTMigLiquidacion
{
    public int EmpId { get; set; }

    public int Periodo { get; set; }

    public string RutTrabajador { get; set; } = null!;

    public int Contrato { get; set; }

    public byte Proceso { get; set; }

    public int PeriodoDevengado { get; set; }

    public int LiqId { get; set; }
}
