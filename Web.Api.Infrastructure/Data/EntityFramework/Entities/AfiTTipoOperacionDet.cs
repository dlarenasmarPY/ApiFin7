using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AfiTTipoOperacionDet
{
    public decimal AfiOpeDetId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal AfiOpeCod { get; set; }

    public byte AfiTipoCalculoCod { get; set; }

    public DateTime FechaVigencia { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
