using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuUserControlComin
{
    public string NomUserControl { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string? EstadoReg { get; set; }

    public DateTime? FecEstadoReg { get; set; }

    public DateTime? FecIngReg { get; set; }

    public string? IdUsuarioIngReg { get; set; }

    public DateTime? FecUltModifReg { get; set; }

    public string? IdUsuarioUltModifReg { get; set; }

    public string? IdFuncionUltModifReg { get; set; }
}
