using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTEstadoCivil
{
    public short CodEstCivil { get; set; }

    public string GlosaEstCivil { get; set; } = null!;
}
