using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflFlechaflujo
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atdiagid { get; set; } = null!;

    public int Atflechaid { get; set; }

    public int Atterminatarea { get; set; }

    public int Atflujoportpovdo { get; set; }

    public string? Atcarpetadestino { get; set; }

    public string Attipoexpqueviaja { get; set; } = null!;

    public int? Attipoexpinic { get; set; }

    public string? Atatributos { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
