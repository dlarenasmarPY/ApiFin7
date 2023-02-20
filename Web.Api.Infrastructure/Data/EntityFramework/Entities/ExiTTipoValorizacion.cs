using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTTipoValorizacion
{
    public byte IndValorizaLote { get; set; }

    public string TipoValorizacionDes { get; set; } = null!;
}
