using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTColumnaLibro
{
    public byte SisCodOri { get; set; }

    public short ClcId { get; set; }

    public string ClcGlosa { get; set; } = null!;
}
