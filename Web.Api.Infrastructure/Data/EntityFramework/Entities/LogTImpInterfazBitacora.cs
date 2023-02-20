using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTImpInterfazBitacora
{
    public string InterfazBitArchivo { get; set; } = null!;

    public DateTime InterfazBitFecha { get; set; }

    public string InterfazBitOwner { get; set; } = null!;

    public byte InterfazBitEstado { get; set; }

    public string InterfazBitIndUnicoPl { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short ProNegocioCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
