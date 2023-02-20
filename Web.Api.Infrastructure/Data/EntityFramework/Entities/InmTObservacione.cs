using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTObservacione
{
    public decimal PAtencionId { get; set; }

    public decimal PTprId { get; set; }

    public string CliRut { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string ObservacGlosa { get; set; } = null!;
}
