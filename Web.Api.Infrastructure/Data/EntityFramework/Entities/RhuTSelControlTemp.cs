using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelControlTemp
{
    public decimal IdControl { get; set; }

    public string SelOwner { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PidOrdenProceso { get; set; }

    public DateTime FecIngReg { get; set; }
}
