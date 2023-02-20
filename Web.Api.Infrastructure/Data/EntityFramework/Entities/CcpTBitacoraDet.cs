using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTBitacoraDet
{
    public decimal BitDetId { get; set; }

    public decimal PBitId { get; set; }

    public short BitFicLinea { get; set; }

    public string BitFicGlosaErr { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual CcpTBitacora PBit { get; set; } = null!;
}
