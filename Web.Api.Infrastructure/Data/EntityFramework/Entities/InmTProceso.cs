using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTProceso
{
    public byte ProcId { get; set; }

    public string ProcGlosa { get; set; } = null!;
}
