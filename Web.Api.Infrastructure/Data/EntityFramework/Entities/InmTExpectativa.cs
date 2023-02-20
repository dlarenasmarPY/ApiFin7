using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTExpectativa
{
    public short ExpId { get; set; }

    public string ExpGlosa { get; set; } = null!;
}
