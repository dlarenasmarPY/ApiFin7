using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTBiePagosRem
{
    public decimal BiePagRemId { get; set; }

    public decimal PNomConcId { get; set; }

    public decimal PCtoId { get; set; }

    public decimal PConcRemId { get; set; }

    public decimal PProcRemPerId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PPerRemId { get; set; }

    public decimal PBeneficiosId { get; set; }

    public decimal ValBeneficio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
