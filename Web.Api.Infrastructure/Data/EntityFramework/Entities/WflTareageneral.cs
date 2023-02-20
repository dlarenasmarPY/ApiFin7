using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflTareageneral
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atdiagid { get; set; } = null!;

    public int Attareaid { get; set; }

    public int Atformaasig { get; set; }

    public int? Attiempoesperado { get; set; }

    public string? Atcarpetaparacopiaexp { get; set; }

    public string? Atclaseformaasig { get; set; }

    public string? Atmetodoformaasig { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
