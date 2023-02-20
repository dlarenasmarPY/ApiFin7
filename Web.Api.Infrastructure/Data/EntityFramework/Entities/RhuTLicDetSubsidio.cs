using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTLicDetSubsidio
{
    public decimal DsuId { get; set; }

    public decimal PLicId { get; set; }

    public decimal PPerRemId { get; set; }

    public byte DsuTipo { get; set; }

    public double DsuBbruta { get; set; }

    public double DsuBimpo { get; set; }

    public double DsuBtrib { get; set; }

    public double DsuBdesa { get; set; }

    public double DsuMtoPension { get; set; }

    public double DsuMtoSalud { get; set; }

    public double DsuMtoSaladi { get; set; }

    public double DsuMtoDesa { get; set; }

    public double DsuMtoImpto { get; set; }

    public double DsuBliquida { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTLicMedica PLic { get; set; } = null!;

    public virtual RhuTRemPeriodo PPerRem { get; set; } = null!;
}
