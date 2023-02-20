using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelSolicitudDet
{
    public decimal SdeId { get; set; }

    public decimal PSctId { get; set; }

    public short CgoCodCargo { get; set; }

    public int SdeNumVacSol { get; set; }

    public int SdeNumVacCon { get; set; }

    public int SdeNumVacReal { get; set; }

    public int SdeNumVacAut { get; set; }

    public string SdeObservacion { get; set; } = null!;

    public string SdeEstado { get; set; } = null!;

    public DateTime SdeFecEstado { get; set; }

    public decimal POrdenProcesoId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelSolicitud PSct { get; set; } = null!;
}
