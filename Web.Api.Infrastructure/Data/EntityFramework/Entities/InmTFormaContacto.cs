using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTFormaContacto
{
    public short FormaId { get; set; }

    public string FormaGlosa { get; set; } = null!;
}
