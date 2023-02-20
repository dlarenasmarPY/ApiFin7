using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTTipoDiferido
{
    public byte TdfCodigo { get; set; }

    public string TdfGlosa { get; set; } = null!;
}
