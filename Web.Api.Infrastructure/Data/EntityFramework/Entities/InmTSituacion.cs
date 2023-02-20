using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTSituacion
{
    public byte SituacionId { get; set; }

    public string SituacionGlosa { get; set; } = null!;
}
