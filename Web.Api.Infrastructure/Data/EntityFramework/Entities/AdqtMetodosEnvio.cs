using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqtMetodosEnvio
{
    public decimal MetodoEnvioId { get; set; }

    public string MetodoEnvioDes { get; set; } = null!;
}
