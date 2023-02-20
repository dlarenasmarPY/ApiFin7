using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtDetCont
{
    public decimal OpeLogtDetContId { get; set; }

    public decimal POpeLogtDetId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PPartidaId { get; set; }

    public decimal PDetReferenciaCtaId { get; set; }

    public decimal PDetReferenciaCctaId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PSaldoCierreId { get; set; }

    public double AcuPorcentajeDet { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCctaId { get; set; }

    public virtual LogTOperacionesLogtDet POpeLogtDet { get; set; } = null!;
}
