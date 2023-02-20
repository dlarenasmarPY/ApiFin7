using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTEntidadEmpresa
{
    public decimal EntEmpId { get; set; }

    public decimal PEmpId { get; set; }

    public decimal PEntId { get; set; }

    public string EntEmpCodPresupuesto { get; set; } = null!;

    public string EntEmpTipoClasificacion { get; set; } = null!;

    public byte EntEmpEstadoCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
