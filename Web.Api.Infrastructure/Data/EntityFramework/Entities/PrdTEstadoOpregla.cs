using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTEstadoOpregla
{
    public string EstadoCod { get; set; } = null!;

    public string EstadoCodDestino { get; set; } = null!;
}
