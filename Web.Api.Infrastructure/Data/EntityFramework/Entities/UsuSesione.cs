using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuSesione
{
    public short IdAdm { get; set; }

    public string IdUsuario { get; set; } = null!;

    public decimal IdSesion { get; set; }

    public DateTime FecInicio { get; set; }

    public DateTime? FecFin { get; set; }

    public string? DireccionIp { get; set; }

    public string? EstadoReg { get; set; }

    public DateTime? FecEstadoReg { get; set; }

    public DateTime? FecIngReg { get; set; }

    public string? IdUsuarioIngReg { get; set; }

    public DateTime? FecUltModifReg { get; set; }

    public string? IdUsuarioUltModifReg { get; set; }

    public string? IdFuncionUltModifReg { get; set; }

    public virtual UsuUsuario Id { get; set; } = null!;
}
