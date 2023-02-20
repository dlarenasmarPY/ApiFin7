using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEmpresaCobrador
{
    public decimal PEmpId { get; set; }

    public short UniCodigoCbza { get; set; }

    public string FldUserCode { get; set; } = null!;

    public byte IndSupervisorCbza { get; set; }
}
