using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTPresupuestoCompra
{
    public decimal PresupCompraId { get; set; }

    public string PresupCompraDes { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public byte IndPptoPeriodo { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public byte ConEstCod { get; set; }

    public byte IndPptoCatProd { get; set; }

    public decimal PCreId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
