using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTParTipoComisione
{
    public byte TipoComision { get; set; }

    public string Descripcion { get; set; } = null!;
}
