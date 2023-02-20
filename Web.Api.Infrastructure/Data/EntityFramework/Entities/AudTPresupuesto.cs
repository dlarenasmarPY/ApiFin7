using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AudTPresupuesto
{
    public decimal AudId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCfgPreId { get; set; }

    public string AudAccion { get; set; } = null!;

    public string AudCampo { get; set; } = null!;

    public double AudValorOld { get; set; }

    public double AudValorNew { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
