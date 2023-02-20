using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTFactorInstCredito
{
    public int InstCod { get; set; }

    public byte AnosDividendo { get; set; }

    public double FactorAnos { get; set; }
}
