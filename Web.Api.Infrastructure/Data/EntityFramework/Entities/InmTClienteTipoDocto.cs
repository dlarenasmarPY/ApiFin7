using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTClienteTipoDocto
{
    public short TcliId { get; set; }

    public short TdoId { get; set; }

    public virtual InmTTipoCliente Tcli { get; set; } = null!;
}
