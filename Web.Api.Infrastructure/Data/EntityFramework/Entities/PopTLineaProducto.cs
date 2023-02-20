using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PopTLineaProducto
{
    public short LineaProId { get; set; }

    public string LineaProDesc { get; set; } = null!;
}
