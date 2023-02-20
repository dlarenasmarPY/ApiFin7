using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTMotivoRechazo
{
    public byte RechazoCod { get; set; }

    public string RechazoDes { get; set; } = null!;
}
