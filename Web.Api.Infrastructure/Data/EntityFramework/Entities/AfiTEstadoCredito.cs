using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTEstadoCredito
{
    public byte AfiEstado { get; set; }

    public string AfiEstadoDes { get; set; } = null!;
}
