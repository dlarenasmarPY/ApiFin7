using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTDescarte
{
    public decimal DescarteId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal PProductoId { get; set; }

    public DateTime FechaIngreso { get; set; }

    public double Cantidad { get; set; }

    public decimal Rendimiento { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
