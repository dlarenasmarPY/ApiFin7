using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTRegimenConyugal
{
    public short CodRegConyugal { get; set; }

    public string GlosaRegConyugal { get; set; } = null!;
}
