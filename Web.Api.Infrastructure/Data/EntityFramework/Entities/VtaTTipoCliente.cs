using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoCliente
{
    public byte TipoCliente { get; set; }

    public string Descripcion { get; set; } = null!;
}
