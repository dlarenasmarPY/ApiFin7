using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpespTec
{
    public decimal OpespTecId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal POpdetId { get; set; }

    public decimal PForEspTecId { get; set; }

    public short EspTecLinea { get; set; }

    public string EspecificacionTec { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
