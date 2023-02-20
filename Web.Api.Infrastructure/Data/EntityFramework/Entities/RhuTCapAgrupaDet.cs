using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapAgrupaDet
{
    public decimal CapAgrDetId { get; set; }

    public decimal PCapAgrId { get; set; }

    public decimal PCreId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapAgrupacion PCapAgr { get; set; } = null!;

    public virtual ConTCentrosResp PCre { get; set; } = null!;
}
