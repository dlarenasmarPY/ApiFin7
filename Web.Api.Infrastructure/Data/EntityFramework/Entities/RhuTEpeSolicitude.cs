using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTEpeSolicitude
{
    public decimal EpeSolId { get; set; }

    public decimal PItmParId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime EpeFechaSol { get; set; }

    public decimal PItmParEstId { get; set; }

    public string EpeGlosaRechazo { get; set; } = null!;

    public decimal EpeIdent01 { get; set; }

    public decimal EpeIdent02 { get; set; }

    public decimal EpeIdent03 { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual RhuTParItem PItmPar { get; set; } = null!;

    public virtual RhuTParItem PItmParEst { get; set; } = null!;

    public virtual ICollection<RhuTEpeSolCertif> RhuTEpeSolCertifs { get; } = new List<RhuTEpeSolCertif>();

    public virtual ICollection<RhuTEpeSolPermiso> RhuTEpeSolPermisos { get; } = new List<RhuTEpeSolPermiso>();

    public virtual ICollection<RhuTEpeSolPersonal> RhuTEpeSolPersonals { get; } = new List<RhuTEpeSolPersonal>();
}
