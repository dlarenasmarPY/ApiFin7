using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCuentasAsociada
{
    public decimal PCtaId { get; set; }

    public string FldUserCode { get; set; } = null!;

    public int CtaCodigo { get; set; }
}
