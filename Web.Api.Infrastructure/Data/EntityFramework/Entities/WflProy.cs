using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflProy
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atnombreproy { get; set; } = null!;

    public int Atfecha { get; set; }

    public string? Atcreador { get; set; }

    public string? Atobservaciones { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
