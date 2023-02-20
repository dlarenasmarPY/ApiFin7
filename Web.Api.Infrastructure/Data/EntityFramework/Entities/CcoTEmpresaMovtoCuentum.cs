using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTEmpresaMovtoCuentum
{
    public decimal PEmpId { get; set; }

    public byte TipMovCcoCod { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCtaIdIngreso { get; set; }

    public decimal PCtaIdEgreso { get; set; }

    public decimal PCtaIdAnticipo { get; set; }

    public decimal PCtaIdGasto { get; set; }

    public decimal PCtaIdInteres { get; set; }

    public decimal PCtaIdUbicacion { get; set; }

    public decimal PCtaIdProtesto { get; set; }

    public decimal PCtaIdDocCancelado { get; set; }

    public decimal PCtaIdDocInvalido { get; set; }

    public decimal PCtaIdCobranza { get; set; }

    public decimal PCtaIdComision { get; set; }
}
