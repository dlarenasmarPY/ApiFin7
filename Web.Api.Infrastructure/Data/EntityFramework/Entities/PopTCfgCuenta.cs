using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTCfgCuenta
{
    public int EmpId { get; set; }

    public int CfgNumId { get; set; }

    public int CtaCodigo { get; set; }

    public int CtaCodigoContra { get; set; }
}
