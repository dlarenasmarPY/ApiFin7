using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRemConfigPer
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public decimal PCtaId { get; set; }

    public short TdoId { get; set; }

    public decimal PConcRemId { get; set; }

    public short Tipo { get; set; }
}
