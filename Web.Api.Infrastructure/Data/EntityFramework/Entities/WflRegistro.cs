using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflRegistro
{
    public int IdAdm { get; set; }

    public int Atregistroid { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atdiagid { get; set; } = null!;

    public string Atllaveexpid { get; set; } = null!;

    public int Atcopiaexpid { get; set; }

    public int? Atcopiapadre { get; set; }

    public int Atflechaid { get; set; }

    public int Attipo { get; set; }

    public int Atfecha { get; set; }

    public string? Atobservacion { get; set; }

    public string? Atperorigen { get; set; }

    public string? Atrolorigen { get; set; }

    public string? Atperdestino { get; set; }

    public string? Atroldestino { get; set; }

    public int? Attareaorigen { get; set; }

    public int? Attareadestino { get; set; }
}
