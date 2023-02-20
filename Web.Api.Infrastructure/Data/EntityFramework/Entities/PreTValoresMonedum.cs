using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PreTValoresMonedum
{
    public byte MonCodigo { get; set; }

    public short PerId { get; set; }

    public decimal ValMonProyectado { get; set; }

    public decimal ValMonReal { get; set; }
}
