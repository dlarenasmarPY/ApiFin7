using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class InmTItemGenerico
{
    public byte ItemGenId { get; set; }

    public string ItemGenGlosa { get; set; } = null!;

    public int IndicadorIva { get; set; }
}
