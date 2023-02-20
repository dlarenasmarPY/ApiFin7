using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTExterior
{
    public decimal ExteriorId { get; set; }

    public decimal PEmpId { get; set; }

    public string ExteriorDes { get; set; } = null!;

    public string ExteriorCod { get; set; } = null!;

    public decimal PUnidadRendimientoId { get; set; }

    public string TypGlosaPrd { get; set; } = null!;

    public double CostoEstandar { get; set; }

    public double CostoEstandarTrib { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCctaId { get; set; }

    public decimal PCdiId { get; set; }
}
