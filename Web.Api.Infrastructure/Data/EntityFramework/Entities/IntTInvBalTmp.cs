using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInvBalTmp
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short EjeAno { get; set; }

    public short PerId { get; set; }

    public string IntTmpOwner { get; set; } = null!;

    public string IntTmpArchivo { get; set; } = null!;

    public string IntTmpRegistro { get; set; } = null!;
}
