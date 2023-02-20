using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgtRecepcionBitSii
{
    public decimal RecepcionBitId { get; set; }

    public string RecDetOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public string BitArchivo { get; set; } = null!;

    public byte IntBitEstado { get; set; }

    public string IntBitIndUnicoPl { get; set; } = null!;

    public DateTime IntBitFecDesde { get; set; }

    public DateTime IntBitFecHasta { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
