using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ImpTCoberturaCab
{
    public decimal CoberturaId { get; set; }

    public DateTime FechaCobertura { get; set; }

    public byte ConEstCod { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FechaEstado { get; set; }

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
