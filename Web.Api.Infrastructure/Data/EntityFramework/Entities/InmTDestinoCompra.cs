using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTDestinoCompra
{
    public byte DesComId { get; set; }

    public string DesComGlosa { get; set; } = null!;
}
