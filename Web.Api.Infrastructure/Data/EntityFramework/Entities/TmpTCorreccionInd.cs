using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCorreccionInd
{
    public string TesDocOwner { get; set; } = null!;

    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public int CtaCodigoOrig { get; set; }

    public int CtaCodigoAcum { get; set; }

    public int CtaCodigoResul { get; set; }

    public int CdiCodigoCtaAcum { get; set; }

    public int CreCodigoCtaAcum { get; set; }

    public int CdiCodigoCtaResul { get; set; }

    public int CreCodigoCtaResul { get; set; }

    public decimal Factor { get; set; }

    public decimal SaldoDeudor { get; set; }

    public decimal SaldoAcreedor { get; set; }

    public decimal SaldoActualizado { get; set; }

    public decimal SaldoCorreccion { get; set; }
}
