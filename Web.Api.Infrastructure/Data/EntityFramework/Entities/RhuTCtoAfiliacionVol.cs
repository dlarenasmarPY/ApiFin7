using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCtoAfiliacionVol
{
    public decimal CtoAfiVolId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PInsParAfiVolId { get; set; }

    public DateTime CtoAfiVolFecInicio { get; set; }

    public short CtoAfiVolPeriodicidad { get; set; }

    public double CtoAfiVolValor { get; set; }

    public decimal PMonedaAfiVolId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCtoContrato PCto { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;

    public virtual RhuTParInstitucione PInsParAfiVol { get; set; } = null!;

    public virtual RhuTParMoneda PMonedaAfiVol { get; set; } = null!;
}
