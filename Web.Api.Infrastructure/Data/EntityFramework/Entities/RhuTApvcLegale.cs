using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTApvcLegale
{
    public decimal ApvcLegId { get; set; }

    public decimal PCtoApvcId { get; set; }

    public decimal PFnqCauId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTApvcEmpresa PCtoApvc { get; set; } = null!;

    public virtual RhuTFnqCausale PFnqCau { get; set; } = null!;
}
