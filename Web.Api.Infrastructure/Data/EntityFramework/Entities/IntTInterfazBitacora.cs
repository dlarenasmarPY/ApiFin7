using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTInterfazBitacora
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public string IntBitArchivo { get; set; } = null!;

    public string IntBitArchivoLco { get; set; } = null!;

    public DateTime IntBitFec { get; set; }

    public string IntBitOwner { get; set; } = null!;

    public byte IntBitEstado { get; set; }

    public string IntBitIndUnicoPl { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
