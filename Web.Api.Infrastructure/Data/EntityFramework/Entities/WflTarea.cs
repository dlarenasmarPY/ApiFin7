using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflTarea
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atdiagid { get; set; } = null!;

    public int Attareaid { get; set; }

    public string? Atproposito { get; set; }

    public string Attitulotarea { get; set; } = null!;

    public string? Atrolrequerido { get; set; }

    public int Attipotarea { get; set; }

    public string? Atclase { get; set; }

    public string? Atmetodo { get; set; }

    public string? Atcoordenadas { get; set; }

    public string? Atclasemanreg { get; set; }

    public string? Atregla { get; set; }

    public string? Atprocesonegocio { get; set; }

    public string? Atmodulo { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string? Atatributos { get; set; }

    public string? Atclasegenid { get; set; }

    public string? Atmetodogenid { get; set; }

    public string? Atclasemasivo { get; set; }

    public string? Atmetodomasivo { get; set; }
}
