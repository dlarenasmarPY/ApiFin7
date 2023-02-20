using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTOpentrega
{
    public decimal OpentregaId { get; set; }

    public decimal POpcabId { get; set; }

    public decimal PTurnoId { get; set; }

    public decimal PMaquinaId { get; set; }

    public decimal PProductoId { get; set; }

    public string LoteProductoCod { get; set; } = null!;

    public decimal PLoteProductoId { get; set; }

    public int NumeroLoteAgrupa { get; set; }

    public double Cantidad { get; set; }

    public string Observacion { get; set; } = null!;

    public DateTime FechaIngresoHora { get; set; }

    public string EstadoProceso { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal POpeLogtCabId { get; set; }
}
