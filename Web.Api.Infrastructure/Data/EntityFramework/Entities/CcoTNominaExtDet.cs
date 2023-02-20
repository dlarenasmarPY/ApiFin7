using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTNominaExtDet
{
    public decimal DetNomExtId { get; set; }

    public decimal PCabNomExtId { get; set; }

    public int DetNomExtLinea { get; set; }

    public decimal PDocCceId { get; set; }

    public decimal PCtaId { get; set; }

    public short MovCceNumCuota { get; set; }

    public double DetNomExtSaldoLocal { get; set; }

    public double DetNomExtSaldoImpu { get; set; }

    public byte DocCceEstado { get; set; }

    public byte DocCceUbiFisCod { get; set; }

    public decimal PEntRutHolding { get; set; }

    public decimal PCabOpeId { get; set; }

    public string DetNomExtNomArchivo { get; set; } = null!;

    public int DetNomExtNumDocEntExt { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
