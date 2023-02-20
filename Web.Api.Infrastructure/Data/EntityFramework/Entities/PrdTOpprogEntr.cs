using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpprogEntr
{
    public decimal OpprogEntrId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal POpdetId { get; set; }

    public decimal PMaquinaId { get; set; }

    public string Observacion { get; set; } = null!;

    public byte IndDape { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
