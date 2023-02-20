using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTOperacionesLogtCabCont
{
    public decimal OpeLogtCabContId { get; set; }

    public decimal POpeLogtCabId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PPartidaId { get; set; }

    public short TdoId { get; set; }

    public int NumeroDocumento { get; set; }

    public DateTime FechaDocumento { get; set; }

    public decimal PCabReferenciaId { get; set; }

    public int CabOpeNumero { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double AcuPorcentajeCab { get; set; }

    public DateTime FechaCentralizacion { get; set; }

    public virtual LogTOperacionesLogtCab POpeLogtCab { get; set; } = null!;
}
