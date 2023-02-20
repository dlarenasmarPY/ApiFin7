using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuUsuariosPerfile
{
    public short IdAdm { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string IdPerfil { get; set; } = null!;

    public string? EstadoReg { get; set; }

    public DateTime? FecEstadoReg { get; set; }

    public DateTime? FecIngReg { get; set; }

    public string? IdUsuarioIngReg { get; set; }

    public DateTime? FecUltModifReg { get; set; }

    public string? IdUsuarioUltModifReg { get; set; }

    public string? IdFuncionUltModifReg { get; set; }

    public virtual UsuPerfile Id { get; set; } = null!;
}
