using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTEstadosDocumento
{
    public short EstDocCod { get; set; }

    public string EstDocGlosa { get; set; } = null!;

    public byte IndContabiliza { get; set; }

    public byte IndConcepto { get; set; }
}
