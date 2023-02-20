using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTCuentasMoneda
{
    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal CtaMonCuentaCorMon { get; set; }

    public decimal CtaMonCcuentaCorMon { get; set; }

    public byte CreFlagDefault { get; set; }

    public decimal CreCodigoCtaAcum { get; set; }

    public int CdiCodigoCtaAcum { get; set; }

    public decimal CreCodigoCtaResul { get; set; }

    public int CdiCodigoCtaResul { get; set; }
}
