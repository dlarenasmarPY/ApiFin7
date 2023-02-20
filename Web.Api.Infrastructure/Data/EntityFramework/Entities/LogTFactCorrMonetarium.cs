using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTFactCorrMonetarium
{
    public decimal PEmpId { get; set; }

    public int EjercicioContable { get; set; }

    public decimal PMonedaId { get; set; }

    public short PeriodoControl { get; set; }

    public double FactorSemestral { get; set; }

    public double FactorAnual { get; set; }
}
