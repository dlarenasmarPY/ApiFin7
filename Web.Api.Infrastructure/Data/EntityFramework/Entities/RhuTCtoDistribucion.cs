using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoDistribucion
{
    public decimal DpaId { get; set; }

    public decimal PCtoId { get; set; }

    public DateTime DpaFecInicio { get; set; }

    public decimal PProcRemId { get; set; }

    public DateTime DpaFecTermino { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public double DpaPorcentaje { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual GlbTEntidadSucursal PEntSuc { get; set; } = null!;

    public virtual RhuTRemProceso PProcRem { get; set; } = null!;
}
