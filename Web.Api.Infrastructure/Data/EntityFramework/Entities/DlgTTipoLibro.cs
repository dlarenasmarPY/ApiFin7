using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTTipoLibro
{
    public short TipoLibroId { get; set; }

    public string TipoLibroGlosa { get; set; } = null!;
}
