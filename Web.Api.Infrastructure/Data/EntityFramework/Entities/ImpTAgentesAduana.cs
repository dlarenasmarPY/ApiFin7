using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTAgentesAduana
{
    public decimal AgenteAdId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PMonedaId { get; set; }

    public double AgenteAdMontoGastos { get; set; }
}
