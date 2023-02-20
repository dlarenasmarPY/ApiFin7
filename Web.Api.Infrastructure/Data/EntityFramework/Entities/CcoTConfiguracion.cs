using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTConfiguracion
{
    public decimal PEmpId { get; set; }

    public short EjeAno { get; set; }

    public short CfgCcoMaxProrrogas { get; set; }

    public double CfgCcoMaxMontoProrroga { get; set; }

    public string JefeCobranza { get; set; } = null!;

    public string CargoJefeCobranza { get; set; } = null!;

    public double CfgCcoMinMtoAbono { get; set; }
}
