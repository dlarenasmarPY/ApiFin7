using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazTmpEnt
{
    public decimal IntPasoId { get; set; }

    public string IntTmpArchivo { get; set; } = null!;

    public int Linea { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public string IntTmpRegistro { get; set; } = null!;
}
