using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTSituacionCob
{
    public short SitCobCod { get; set; }

    public string SitCobGlosa { get; set; } = null!;

    public byte SitCobSeleccion { get; set; }
}
