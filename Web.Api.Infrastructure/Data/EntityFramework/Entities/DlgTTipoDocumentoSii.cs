using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTTipoDocumentoSii
{
    public short TdoSii { get; set; }

    public string TdoGlosaSii { get; set; } = null!;
}
