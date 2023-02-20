using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidadAtributo
{
    public byte CodAtributo { get; set; }

    public byte IndCategoria { get; set; }

    public string EntGlosaAtributo { get; set; } = null!;

    public byte IndObligacion { get; set; }
}
