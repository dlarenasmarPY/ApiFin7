using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTResulReclamosDte
{
    public string CodOwner { get; set; } = null!;

    public int DlcFolioDocto { get; set; }

    public short TdoSii { get; set; }

    public string RutEmisor { get; set; } = null!;

    public decimal PRecepcionDetId { get; set; }

    public short CodError { get; set; }

    public string GlosaError255 { get; set; } = null!;
}
