using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CceTSaldosDocum
{
    public decimal SalCceId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public decimal PDocCceId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public short MovCceNumCuota { get; set; }

    public DateTime DocCceFecEmi { get; set; }

    public DateTime DocCceFecVenc { get; set; }

    public DateTime DocCceFecProyectada { get; set; }

    public DateTime DocCceFecProrroga { get; set; }

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public double MovCceMontoConvDebe { get; set; }

    public double MovCceMontoConvHaber { get; set; }

    public double SalCceMontoOriginal { get; set; }

    public double SalCceMontoCapital { get; set; }

    public double SalCceMontoInteres { get; set; }

    public double SalCceGastoProtesto { get; set; }
}
