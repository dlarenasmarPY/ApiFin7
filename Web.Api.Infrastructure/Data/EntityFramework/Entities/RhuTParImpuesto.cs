using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTParImpuesto
{
    public decimal ImpId { get; set; }

    public byte ImpTramo { get; set; }

    public DateTime ImpFecVigenciaTramo { get; set; }

    public double ImpDesdeUtm { get; set; }

    public double ImpTopeUtm { get; set; }

    public double ImpRebajaUtm { get; set; }

    public decimal ImpTasa { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
