using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTGastoProtesto
{
    public decimal GasProId { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public double GasProMontoLocalDebe { get; set; }

    public double GasProMontoLocalHaber { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
