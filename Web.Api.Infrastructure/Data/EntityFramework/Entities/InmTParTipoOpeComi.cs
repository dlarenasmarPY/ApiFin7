using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTParTipoOpeComi
{
    public byte TipoOpe { get; set; }

    public string Descripcion { get; set; } = null!;
}
