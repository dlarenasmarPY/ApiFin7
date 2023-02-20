using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTSaldosCajaBanco
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int InstCod { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime FechaSaldo { get; set; }

    public decimal SdoMtoDebe { get; set; }

    public decimal SdoMtoHaber { get; set; }

    public decimal Saldo { get; set; }

    public decimal SdoMtoImpuDebe { get; set; }

    public decimal SdoMtoImpuHaber { get; set; }
}
