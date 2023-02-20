using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuCuotasCtaCte
{
    public string CodOwner { get; set; } = null!;

    public decimal PNomConcId { get; set; }

    public decimal PMovCceId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal Saldo { get; set; }

    public decimal PCtaId { get; set; }

    public short TdoId { get; set; }
}
