using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class AdqTCondicionPago
{
    public decimal CondPagoId { get; set; }

    public int CondPagoCod { get; set; }

    public string CondPagoDes { get; set; } = null!;

    public decimal PFormaPagoId { get; set; }

    public DateTime FechaVigencia { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte CfgDias { get; set; }

    public virtual GlbTFormaPago PFormaPago { get; set; } = null!;
}
