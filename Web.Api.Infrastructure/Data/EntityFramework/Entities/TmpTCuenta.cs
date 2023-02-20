using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCuenta
{
    public decimal PCtaId { get; set; }

    public string FldUserCode { get; set; } = null!;
}
