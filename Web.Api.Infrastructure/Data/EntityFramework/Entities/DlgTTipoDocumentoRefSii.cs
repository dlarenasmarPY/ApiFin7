using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTTipoDocumentoRefSii
{
    public decimal TdoReferenciaSiiId { get; set; }

    public short TdoSii { get; set; }

    public string TdoGlosaSii { get; set; } = null!;

    public byte TdoIndSii { get; set; }

    public string TdoCodigoTag { get; set; } = null!;

    public string TdoContenidoTag { get; set; } = null!;
}
