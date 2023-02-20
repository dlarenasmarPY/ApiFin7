using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflDiag
{
    public int IdAdm { get; set; }

    public int Atproyid { get; set; }

    public int Atversionid { get; set; }

    public string Atdiagid { get; set; } = null!;

    public string? Attitulodiag { get; set; }

    public string? Atdescripcion { get; set; }

    public int? Atlapso { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
