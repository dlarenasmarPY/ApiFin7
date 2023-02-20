using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoTmpTseleccion
{
    public decimal PEmpId { get; set; }

    public string FldUserCode { get; set; } = null!;

    public decimal PCtoId { get; set; }
}
