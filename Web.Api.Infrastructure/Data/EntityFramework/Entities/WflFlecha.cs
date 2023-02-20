using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflFlecha
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atdiagid { get; set; } = null!;

    public int Atflechaid { get; set; }

    public string Atnombreflecha { get; set; } = null!;

    public int Attareaorigen { get; set; }

    public string Atdiagdestino { get; set; } = null!;

    public int Attareadestino { get; set; }

    public int Attipoflecha { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
