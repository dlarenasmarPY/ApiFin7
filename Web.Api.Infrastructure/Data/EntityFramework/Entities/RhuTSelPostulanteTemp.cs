using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelPostulanteTemp
{
    public decimal IdPostulanteTemp { get; set; }

    public string SelOwner { get; set; } = null!;

    public decimal PidOrdenProceso { get; set; }

    public decimal PFicPerId { get; set; }

    public decimal PidPostulante { get; set; }

    public short NumCorrelativo { get; set; }

    public string PerfilAprobado { get; set; } = null!;

    public decimal PItmEstadoPostula { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelOrdenProceso PidOrdenProcesoNavigation { get; set; } = null!;
}
