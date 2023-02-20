using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazErrorEnt
{
    public string IntTmpOwner { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Rut { get; set; } = null!;

    public int CabOpeLinea { get; set; }

    public string IntBitArchivo { get; set; } = null!;

    public string IntGlosaError { get; set; } = null!;
}
