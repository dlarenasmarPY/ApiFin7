using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WflTipoexp
{
    public int IdAdm { get; set; }

    public string Attipoexpid { get; set; } = null!;

    public string Attitulo { get; set; } = null!;

    public int Atrepresentacion { get; set; }

    public string? Atdescripcion { get; set; }

    public string? Atclase { get; set; }

    public string? Atmetodo { get; set; }

    public string? Atatributos { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
