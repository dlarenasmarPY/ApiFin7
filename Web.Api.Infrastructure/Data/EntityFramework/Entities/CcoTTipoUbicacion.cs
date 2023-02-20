using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTTipoUbicacion
{
    public byte TipUbiCod { get; set; }

    public string TipUbiGlosa { get; set; } = null!;

    public byte TipUbiContab { get; set; }

    public string TipUbiInd { get; set; } = null!;
}
