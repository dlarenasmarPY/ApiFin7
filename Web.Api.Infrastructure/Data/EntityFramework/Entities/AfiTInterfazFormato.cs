using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTInterfazFormato
{
    public short IntFmtOrden { get; set; }

    public string IntFmtCampo { get; set; } = null!;

    public byte IntFmtObligatorio { get; set; }

    public byte IntFmtDefecto { get; set; }

    public string IntFmtValor { get; set; } = null!;

    public string TipoDato { get; set; } = null!;
}
