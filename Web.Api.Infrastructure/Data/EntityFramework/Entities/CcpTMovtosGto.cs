using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcpTMovtosGto
{
    public decimal PDetCcpId { get; set; }

    public decimal PEntId { get; set; }

    public string LlgDocNumDoc { get; set; } = null!;

    public decimal LlgDocMtoImpuNeto { get; set; }

    public decimal LlgDocMtoImpuExento { get; set; }

    public decimal LlgDocMtoImpuIva { get; set; }

    public decimal LlgDocMtoImpuRete { get; set; }

    public decimal LlgDocMtoImpuTotal { get; set; }

    public short OpeCod { get; set; }

    public decimal PCabLlgId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual CcpTMovimiento PDetCcp { get; set; } = null!;

    public virtual GlbTEntidad PEnt { get; set; } = null!;
}
