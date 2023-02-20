using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTIpc
{
    public short PerId { get; set; }

    public double IpcValor { get; set; }

    public double IpcFactor { get; set; }

    public double IpcIndice { get; set; }
}
