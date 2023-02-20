using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflReasignacionLog
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atllaveexpid { get; set; } = null!;

    public int Atcopiaexpid { get; set; }

    public DateTime FecIngReg { get; set; }

    public string? Atobs { get; set; }
}
