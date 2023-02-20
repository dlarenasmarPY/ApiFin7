using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTMediosRescate
{
    public byte TmrCodigo { get; set; }

    public string TmrNombre { get; set; } = null!;

    public string TmrNombreCorto { get; set; } = null!;

    public short TdoId { get; set; }
}
