using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ParAgencia
{
    public short IdAdm { get; set; }

    public short CodAgencia { get; set; }

    public string? Descripcion { get; set; }

    public string Direccion { get; set; } = null!;

    public int CodComuna { get; set; }

    public int Folioreclamo650 { get; set; }

    public short CodSubgerencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public string? HorarioAtencion { get; set; }

    public int? CodZona { get; set; }
}
