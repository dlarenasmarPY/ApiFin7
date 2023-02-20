using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTEstadoOp
{
    public string EstadoCod { get; set; } = null!;

    public string EstadoDes { get; set; } = null!;

    public int OrdenProd { get; set; }
}
