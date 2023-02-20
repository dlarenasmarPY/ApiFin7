using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTCategoriaCliente
{
    public short CategoriaId { get; set; }

    public string CategoriaGlosa { get; set; } = null!;
}
