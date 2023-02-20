using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuUsuario
{
    public short IdAdm { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string IdPersona { get; set; } = null!;

    public string? Nombre { get; set; }

    public string Estado { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public short CodCargo { get; set; }

    public short CodAgencia { get; set; }

    public int? CodComuna { get; set; }

    public short CodArea { get; set; }

    public string IndBloqueo { get; set; } = null!;

    public string? IdUsuarioJefe { get; set; }

    public string Clave { get; set; } = null!;

    public DateTime FecExpClave { get; set; }

    public short? CantIntentos { get; set; }

    public DateTime? FecUltIngreso { get; set; }

    public string? CodSafp { get; set; }

    public string? Email { get; set; }

    public string? EstadoReg { get; set; }

    public DateTime? FecEstadoReg { get; set; }

    public DateTime? FecIngReg { get; set; }

    public string? IdUsuarioIngReg { get; set; }

    public DateTime? FecUltModifReg { get; set; }

    public string? IdUsuarioUltModifReg { get; set; }

    public string? IdFuncionUltModifReg { get; set; }

    public virtual ICollection<UsuSesione> UsuSesiones { get; } = new List<UsuSesione>();
}
