using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBieBeneficiosRemun
{
    public decimal BenRemId { get; set; }

    public decimal PBeneficiosId { get; set; }

    public decimal PEmpId { get; set; }

    public DateTime FecDesde { get; set; }

    public decimal PProcRemId { get; set; }

    public decimal PConcRemId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTBieBeneficio PBeneficios { get; set; } = null!;
}
