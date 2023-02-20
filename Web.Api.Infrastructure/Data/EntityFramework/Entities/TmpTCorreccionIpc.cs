using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTCorreccionIpc
{
    public string TesDocOwner { get; set; } = null!;

    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int CtaCodigo { get; set; }

    public int CreCodigo { get; set; }

    public byte MonCodigo { get; set; }

    public decimal SalMtoImpuDebe { get; set; }

    public decimal SalMtoImpuHaber { get; set; }

    public decimal SalMtoLocalDebe { get; set; }

    public decimal SalMtoLocalHaber { get; set; }
}
