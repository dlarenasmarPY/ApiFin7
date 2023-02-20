using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LlgTClasificaIva
{
    public byte ClaIvaId { get; set; }

    public string ClaIvaGlosa { get; set; } = null!;

    public byte ClaIvaCodigoSii { get; set; }
}
