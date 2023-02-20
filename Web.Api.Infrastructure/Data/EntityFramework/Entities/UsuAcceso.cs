using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuAcceso
{
    public int IdAdm { get; set; }

    public decimal IdAcceso { get; set; }

    public string IdFuncionalidad { get; set; } = null!;

    public DateTime FecAcceso { get; set; }

    public string? Ip { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
