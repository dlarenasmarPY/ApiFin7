using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class UsuRole
{
    public short IdAdm { get; set; }

    public string IdRol { get; set; } = null!;

    public string IdProcesoNegocio { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string IndAdminPn { get; set; } = null!;

    public string? TipoRolWorkflow { get; set; }

    public string? EstadoReg { get; set; }

    public DateTime? FecEstadoReg { get; set; }

    public DateTime? FecIngReg { get; set; }

    public string? IdUsuarioIngReg { get; set; }

    public DateTime? FecUltModifReg { get; set; }

    public string? IdUsuarioUltModifReg { get; set; }

    public string? IdFuncionUltModifReg { get; set; }
}
