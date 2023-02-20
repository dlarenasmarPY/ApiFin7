using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoImagen
{
    public byte TigCodigo { get; set; }

    public string TigGlosa { get; set; } = null!;
}
