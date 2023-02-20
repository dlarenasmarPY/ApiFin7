using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflExp
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atllaveexpid { get; set; } = null!;

    public string Attipoexpasociado { get; set; } = null!;

    public string? Atdescripcion { get; set; }

    public string? Atobs { get; set; }

    public string? Atlistacd { get; set; }

    public int? Atfechainicio { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
