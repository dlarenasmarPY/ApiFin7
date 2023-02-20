using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTUtillaje
{
    public decimal UtillajeId { get; set; }

    public decimal PEmpId { get; set; }

    public string UtillajeDes { get; set; } = null!;

    public string UtillajeCod { get; set; } = null!;

    public decimal PUnidadRendimientoId { get; set; }

    public double ValorUtillaje { get; set; }

    public double UnidadesVidaUtil { get; set; }

    public double UnidadesUtilizadas { get; set; }

    public decimal POpentregaId { get; set; }

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
}
