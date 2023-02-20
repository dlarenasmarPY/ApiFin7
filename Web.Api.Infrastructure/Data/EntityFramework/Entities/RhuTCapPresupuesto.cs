using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTCapPresupuesto
{
    public decimal CapPptoId { get; set; }

    public decimal PCapConfId { get; set; }

    public short EjeAno { get; set; }

    public short DivCodigo { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCapAgrId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal CapMtoPpto { get; set; }

    public decimal CapMtoUsado { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual RhuTCapConfigEmp PCapConf { get; set; } = null!;
}
