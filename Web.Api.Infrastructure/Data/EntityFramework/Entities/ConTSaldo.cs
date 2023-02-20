using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTSaldo
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public short PerId { get; set; }

    public decimal PMonedaId { get; set; }

    public double SalMtoImpuDebe { get; set; }

    public double SalMtoImpuHaber { get; set; }

    public double SalMtoLocalDebe { get; set; }

    public double SalMtoLocalHaber { get; set; }

    public double SalMtoConvDebe { get; set; }

    public double SalMtoConvHaber { get; set; }
}
