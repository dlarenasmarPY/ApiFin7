using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTImpFormato
{
    public short IntFmtOrden { get; set; }

    public string IntFmtCampo { get; set; } = null!;

    public short IntFmtPosIni { get; set; }

    public short IntFmtLargo { get; set; }

    public byte IntFmtObligatorio { get; set; }

    public byte IntFmtDefecto { get; set; }

    public string IntFmtValor { get; set; } = null!;

    public string TipoDato { get; set; } = null!;
}
