using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTImpuestosProducto
{
    public decimal ImpuestoProdId { get; set; }

    public decimal PImpuestoId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PServicioId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual LogTImpuesto PImpuesto { get; set; } = null!;
}
