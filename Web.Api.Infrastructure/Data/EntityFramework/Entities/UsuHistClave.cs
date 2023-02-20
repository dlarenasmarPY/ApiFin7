using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuHistClave
{
    public int IdAdm { get; set; }

    public string IdUsuario { get; set; } = null!;

    public DateTime Fec { get; set; }

    public int Tipo { get; set; }

    public string? Clave { get; set; }

    public string? EstadoReg { get; set; }

    public DateTime? FecEstadoReg { get; set; }

    public DateTime? FecIngReg { get; set; }

    public string? IdUsuarioIngReg { get; set; }

    public DateTime? FecUltModifReg { get; set; }

    public string? IdUsuarioUltModifReg { get; set; }

    public string? IdFuncionUltModifReg { get; set; }
}
