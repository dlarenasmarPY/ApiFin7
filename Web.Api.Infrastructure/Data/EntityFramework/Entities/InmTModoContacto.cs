using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTModoContacto
{
    public short ModoId { get; set; }

    public string ModoGlosa { get; set; } = null!;
}
