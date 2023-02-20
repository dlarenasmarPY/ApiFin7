using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTEstado
{
    public byte TipoEstado { get; set; }

    public byte EstCodigo { get; set; }

    public string EstNombre { get; set; } = null!;
}
