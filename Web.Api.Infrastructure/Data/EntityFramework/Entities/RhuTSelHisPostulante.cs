using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTSelHisPostulante
{
    public decimal IdPostulanteHistorico { get; set; }

    public decimal PidPostulante { get; set; }

    public decimal PidCargoPostulante { get; set; }

    public decimal PidOrdenProceso { get; set; }

    public decimal PidOrdenProcesoEval { get; set; }

    public double PorRanking { get; set; }

    public string CodEstadoPostulante { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTSelPostulante PidPostulanteNavigation { get; set; } = null!;
}
