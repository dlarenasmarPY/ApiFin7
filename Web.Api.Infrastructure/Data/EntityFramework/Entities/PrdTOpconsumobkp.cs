using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpconsumobkp
{
    public decimal OpconsumoId { get; set; }

    public decimal POpcabId { get; set; }

    public string LoteProductoCod { get; set; } = null!;

    public DateTime FechaIngresoHora { get; set; }

    public string EstadoProceso { get; set; } = null!;

    public decimal PBodegaIdSolicitud { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
