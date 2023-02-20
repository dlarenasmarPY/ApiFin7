using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTReglaRecepGenerica
{
    public short RrgCodigo { get; set; }

    public string RrgGlosa { get; set; } = null!;
}
