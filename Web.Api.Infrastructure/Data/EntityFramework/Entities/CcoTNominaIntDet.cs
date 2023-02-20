using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTNominaIntDet
{
    public decimal DetNomId { get; set; }

    public decimal PCabNomId { get; set; }

    public decimal PDocCceId { get; set; }

    public short MovCceNumCuota { get; set; }

    public decimal PCtaId { get; set; }

    public double DetNomSaldoLocal { get; set; }

    public double DetNomSaldoImpu { get; set; }

    public decimal PEntRutHolding { get; set; }

    public decimal PCabOpeId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
