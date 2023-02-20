using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelDocumentoCargo
{
    public decimal IdDocumento { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PItmDocSelId { get; set; }

    public string IndObligatorio { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParCargo CgoCodCargoNavigation { get; set; } = null!;
}
