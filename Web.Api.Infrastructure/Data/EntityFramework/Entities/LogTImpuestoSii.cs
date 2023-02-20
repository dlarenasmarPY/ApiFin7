using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTImpuestoSii
{
    public short IsiiCodigo { get; set; }

    public string IsiiDescripcion { get; set; } = null!;

    public string IsiiDescripcionLarga { get; set; } = null!;
}
