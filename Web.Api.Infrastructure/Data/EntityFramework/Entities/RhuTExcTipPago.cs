using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTExcTipPago
{
    public decimal TpaId { get; set; }

    public decimal PExcEsaId { get; set; }

    public decimal PConcRemId { get; set; }

    public byte TpaCod { get; set; }

    public string TpaGlosa { get; set; } = null!;

    public double TpaMonto { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTRemConcepto PConcRem { get; set; } = null!;

    public virtual RhuTExcEmpresa PExcEsa { get; set; } = null!;

    public virtual ICollection<RhuTExcPago> RhuTExcPagos { get; } = new List<RhuTExcPago>();
}
