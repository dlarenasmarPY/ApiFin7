using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TesTMovimientosCf
{
    public decimal MovTesCfId { get; set; }

    public decimal PMovTesId { get; set; }

    public decimal PCabOpeId { get; set; }

    public int CabOpeLineaCorr { get; set; }

    public int CfiCodigo { get; set; }

    public double MovTesMontoImpuDebe { get; set; }

    public double MovTesMontoImpuHaber { get; set; }

    public double MovTesMontoLocalDebe { get; set; }

    public double MovTesMontoLocalHaber { get; set; }

    public double MovTesMontoConvDebe { get; set; }

    public double MovTesMontoConvHaber { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ConTCabeceraOpe PCabOpe { get; set; } = null!;

    public virtual TesTMovimiento PMovTes { get; set; } = null!;
}
