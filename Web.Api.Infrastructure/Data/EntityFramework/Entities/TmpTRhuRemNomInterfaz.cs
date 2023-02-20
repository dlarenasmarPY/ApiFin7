using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemNomInterfaz
{
    public decimal PNomConcId { get; set; }

    public string NcnImpNombreArchivo { get; set; } = null!;

    public short NcnImpLinea { get; set; }

    public string NcnImpRegistro { get; set; } = null!;

    public byte NcnImpRegError { get; set; }
}
