using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgtUbicacionBak
{
    public byte SisCodOri { get; set; }

    public short LblCod { get; set; }

    public short UblId { get; set; }

    public string UblGlosa { get; set; } = null!;

    public byte SumaDoc { get; set; }

    public short TdoSii { get; set; }

    public byte IndDlgMe { get; set; }

    public int ImpSiiId { get; set; }
}
