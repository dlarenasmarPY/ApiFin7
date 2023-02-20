using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ApfTFormaPago
{
    public short TfpCodigo { get; set; }

    public string TfpNombre { get; set; } = null!;

    public string TfpNombreCorto { get; set; } = null!;

    public short TdoId { get; set; }
}
