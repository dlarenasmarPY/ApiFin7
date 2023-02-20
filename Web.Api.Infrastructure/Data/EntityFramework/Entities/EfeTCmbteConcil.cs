using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class EfeTCmbteConcil
{
    public decimal PEmpId { get; set; }

    public short PerId { get; set; }

    public decimal EfeFlujoEstConcCod { get; set; }

    public double MovConMontoLocalDebe { get; set; }

    public double MovConMontoLocalHaber { get; set; }

    public double MovConMontoConvDebe { get; set; }

    public double MovConMontoConvHaber { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
