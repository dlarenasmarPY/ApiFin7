using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConTAuditaSaldo
{
    public short AuditaSaldoCod { get; set; }

    public string AuditaSaldoGlosa { get; set; } = null!;

    public string AuditaSaldoSigno { get; set; } = null!;

    public double AuditaSaldoValor { get; set; }
}
