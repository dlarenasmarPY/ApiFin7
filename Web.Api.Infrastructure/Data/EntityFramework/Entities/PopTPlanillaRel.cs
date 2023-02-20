using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTPlanillaRel
{
    public int EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public int CfgNumId { get; set; }

    public int CreCodigo { get; set; }

    public string FldUserCode { get; set; } = null!;

    public string FldUserCodeRel { get; set; } = null!;
}
