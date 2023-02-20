using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ParDatosClave
{
    public decimal IdAdm { get; set; }

    public decimal Id { get; set; }

    public decimal? LargoMinimo { get; set; }

    public decimal? LargoMaximo { get; set; }

    public decimal? DiasExpira { get; set; }

    public decimal? DiasAviso { get; set; }

    public decimal? NumIntentos { get; set; }

    public decimal? DiasInactivo { get; set; }

    public string? Expresion { get; set; }

    public string? Expresiondesc { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
