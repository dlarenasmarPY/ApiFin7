using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTAtributo
{
    public decimal AtributoId { get; set; }

    public string AtributoNombre { get; set; } = null!;

    public string AtributoDato { get; set; } = null!;

    public short AtributoLargo { get; set; }

    public byte AtributoDecimal { get; set; }

    public string AtributoDefecto { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
