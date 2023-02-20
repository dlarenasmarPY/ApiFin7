using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTForOperacion
{
    public decimal ForOperacionId { get; set; }

    public decimal PFormulaId { get; set; }

    public decimal POperacionId { get; set; }

    public double CantidadFor { get; set; }

    public decimal PorSobreConsumo { get; set; }

    public int SecuenciaFor { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
