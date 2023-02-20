using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTInterfazErrorBaja
{
    public string IntTmpOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short AfiGrupoCod { get; set; }

    public decimal AfiCodigo { get; set; }

    public decimal AfiSecuencia { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public int Linea { get; set; }

    public string IntBitArchivo { get; set; } = null!;

    public string IntGlosaError { get; set; } = null!;
}
