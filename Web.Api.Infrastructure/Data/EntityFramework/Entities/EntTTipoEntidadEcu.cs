using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class EntTTipoEntidadEcu
{
    public byte Ident { get; set; }

    public string DescripcionTipo { get; set; } = null!;

    public string CodigoSri { get; set; } = null!;

    public string ModuloDv { get; set; } = null!;
}
