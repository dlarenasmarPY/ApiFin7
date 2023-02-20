using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTTipoSociedad
{
    public byte EntTipoSociedadCod { get; set; }

    public string EntTipoSociedadDes { get; set; } = null!;
}
