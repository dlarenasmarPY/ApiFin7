using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTPasivosDeuda
{
    public decimal PEntId { get; set; }

    public int IdenCorrelativo { get; set; }

    public string InstEndeudamiento { get; set; } = null!;

    public string DestinoCredito { get; set; } = null!;

    public short CuotasPorPagar { get; set; }

    public double MontoCuota { get; set; }

    public double SaldoCredito { get; set; }
}
