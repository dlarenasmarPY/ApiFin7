using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelPerfil
{
    public decimal IdPerfil { get; set; }

    public short CgoCodCargo { get; set; }

    public decimal PEmpId { get; set; }

    public short CodRequisito { get; set; }

    public decimal PItmCodCondicion { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTParCargo CgoCodCargoNavigation { get; set; } = null!;
}
