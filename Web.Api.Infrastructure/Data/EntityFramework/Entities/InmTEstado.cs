using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTEstado
{
    public byte TipoEstado { get; set; }

    public byte DocEstado { get; set; }

    public string Descripcion { get; set; } = null!;

    public string InmuebleColor { get; set; } = null!;
}
