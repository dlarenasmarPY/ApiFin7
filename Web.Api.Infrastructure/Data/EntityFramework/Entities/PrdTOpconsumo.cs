using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpconsumo
{
    public decimal OpconsumoId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal PProductoId { get; set; }

    public string LoteProductoCod { get; set; } = null!;

    public DateTime FechaIngresoHora { get; set; }

    public string EstadoProceso { get; set; } = null!;

    public decimal PBodegaIdSolicitud { get; set; }

    public double Cantidad { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double CantidadEntrega { get; set; }

    public decimal POpeLogtCabId { get; set; }

    public decimal PUbicacionId { get; set; }

    public decimal PLoteProductoId { get; set; }

    public string CodOwner { get; set; } = null!;

    public string TipoVolcado { get; set; } = null!;

    public decimal PMaquinaId { get; set; }
}
