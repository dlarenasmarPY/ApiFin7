using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTImpuestoSii
{
    public int ImpSiiId { get; set; }

    public string ImpSiiGlosa { get; set; } = null!;

    public double ImpSiiTasa { get; set; }

    public byte IndImpRet { get; set; }
}
