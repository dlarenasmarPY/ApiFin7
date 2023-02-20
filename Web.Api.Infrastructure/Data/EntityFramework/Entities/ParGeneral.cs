using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ParGeneral
{
    public short IdAdm { get; set; }

    public string CodParametro { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string IdProcesoNegocio { get; set; } = null!;

    public string NombreTabla { get; set; } = null!;

    public string? TipoParametro { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte[]? Columnas { get; set; }
}
