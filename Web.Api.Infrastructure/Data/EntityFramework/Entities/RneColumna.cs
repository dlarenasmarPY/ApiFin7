using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RneColumna
{
    public long Numrep { get; set; }

    public long Numcol { get; set; }

    public string? Nomcol { get; set; }

    public string? Descol { get; set; }

    public string? Fmtcol { get; set; }

    public string? Tipcol { get; set; }

    public double? Ordcol { get; set; }

    public string? Alitit { get; set; }

    public string? Alicol { get; set; }

    public double? Numtab { get; set; }

    public string? Tipdat { get; set; }

    public string? Sensql { get; set; }

    public string? Colvis { get; set; }

    public string? Perfil { get; set; }

    public double? Lencol { get; set; }

    public string? Indtot { get; set; }

    public string? Estreg { get; set; }

    public string? Fecact { get; set; }

    public double? Usuact { get; set; }
}
