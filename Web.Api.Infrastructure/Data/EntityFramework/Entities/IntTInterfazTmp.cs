using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazTmp
{
    public decimal IntPasoId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string IntTmpArchivo { get; set; } = null!;

    public string IntTmpOwner { get; set; } = null!;

    public string IntTmpRegistro { get; set; } = null!;
}
