using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflAlarma
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public int Atalarmaid { get; set; }

    public int Atfechainicial { get; set; }

    public int Atfechafinal { get; set; }

    public int Atfechafinalposible { get; set; }

    public string Atdiaginicio { get; set; } = null!;

    public int Attareainicio { get; set; }

    public string Atllaveexp { get; set; } = null!;

    public int? Atcopiaalarmada { get; set; }

    public int? Atflechaalarma { get; set; }

    public int? Atactivada { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
