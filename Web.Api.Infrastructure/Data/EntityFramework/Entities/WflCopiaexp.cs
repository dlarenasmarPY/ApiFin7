using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflCopiaexp
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atllaveexpid { get; set; } = null!;

    public int Atcopiaexpid { get; set; }

    public string? Atcarpetaactual { get; set; }

    public string? Atdiagactual { get; set; }

    public int? Attareaactual { get; set; }

    public int Atasignada { get; set; }

    public int Atesdespachable { get; set; }

    public int Atfecha { get; set; }

    public int Atpendpordesp { get; set; }

    public string? Atpersonaasignada { get; set; }

    public string? Atobs { get; set; }

    public string? Atdescripcion { get; set; }

    public string Attipoexpasociado { get; set; } = null!;

    public string? Atatributos { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
