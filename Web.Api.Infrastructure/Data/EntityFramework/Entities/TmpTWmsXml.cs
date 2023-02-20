using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTWmsXml
{
    public decimal WmsIdDocto { get; set; }

    public string WmsXmlEnviado { get; set; } = null!;
}
