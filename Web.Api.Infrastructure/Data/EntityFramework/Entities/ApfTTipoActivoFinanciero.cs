using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTTipoActivoFinanciero
{
    public short TafCodigo { get; set; }

    public string TafNombre { get; set; } = null!;

    public string TafNombreCorto { get; set; } = null!;
}
