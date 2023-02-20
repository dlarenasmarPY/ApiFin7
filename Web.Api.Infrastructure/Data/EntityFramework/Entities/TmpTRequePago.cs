using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRequePago
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public string Rut { get; set; } = null!;

    public short SucNumero { get; set; }

    public decimal PDocCceId { get; set; }

    public decimal Saldo { get; set; }

    public string FldUserCode { get; set; } = null!;

    public decimal PMovCceId { get; set; }

    public short MovCceNumCuota { get; set; }
}
