using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTImpInterfazError
{
    public decimal InterfazErrorId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short ProNegocioCod { get; set; }

    public string InterfazBitArchivo { get; set; } = null!;

    public decimal PTipoOpeId { get; set; }

    public int BodegaCod { get; set; }

    public int CconsumoCod { get; set; }

    public int BodegaDestinoCod { get; set; }

    public string ProductoCod { get; set; } = null!;

    public string IntGlosaError { get; set; } = null!;

    public decimal IdDocumento { get; set; }
}
