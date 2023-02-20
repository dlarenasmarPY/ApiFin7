using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTConveniosInst
{
    public short ConveId { get; set; }

    public string ConveGlosa { get; set; } = null!;
}
