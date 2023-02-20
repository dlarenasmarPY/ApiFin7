using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class GlbTFormaPago
{
    public decimal FormaPagoId { get; set; }

    public byte FormaPagoReca { get; set; }

    public string FormaPagoGlosa { get; set; } = null!;

    public byte FormaPagoInd { get; set; }

    public byte TauId { get; set; }

    public decimal PCtaId { get; set; }

    public byte FormaPagoDias { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte FormaPagoBanco { get; set; }

    public short FormaPagoCodExt { get; set; }

    public virtual ICollection<AdqTCondicionPago> AdqTCondicionPagos { get; } = new List<AdqTCondicionPago>();
}
