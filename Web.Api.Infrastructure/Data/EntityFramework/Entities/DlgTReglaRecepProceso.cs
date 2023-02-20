using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTReglaRecepProceso
{
    public byte RrcCodProceso { get; set; }

    public string RrcGlosaProceso { get; set; } = null!;

    public byte RrcIndResultado { get; set; }
}
