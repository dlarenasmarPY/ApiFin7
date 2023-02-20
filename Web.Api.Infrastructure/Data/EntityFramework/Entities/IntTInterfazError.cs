using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazError
{
    public string IntTmpOwner { get; set; } = null!;

    public byte SisCodOri { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public int IntPeriodo { get; set; }

    public short OpeCod { get; set; }

    public int CabOpeNumero { get; set; }

    public int CabOpeLinea { get; set; }

    public string IntBitArchivo { get; set; } = null!;

    public string IntGlosaError { get; set; } = null!;

    public string LlgDocNumDoc { get; set; } = null!;
}
