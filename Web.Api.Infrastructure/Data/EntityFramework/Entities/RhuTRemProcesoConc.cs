using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTRemProcesoConc
{
    public decimal ProcConcId { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PConcRemId { get; set; }

    public int CprPrioridadCalc { get; set; }

    public DateTime CprFecIniVigencia { get; set; }

    public DateTime CprFecTerVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual RhuTRemProceso PProcRem { get; set; } = null!;
}
