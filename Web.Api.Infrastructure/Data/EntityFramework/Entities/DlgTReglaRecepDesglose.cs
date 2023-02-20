using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTReglaRecepDesglose
{
    public byte RrcIndDesglose { get; set; }

    public string RrcGlosaDesglose { get; set; } = null!;
}
