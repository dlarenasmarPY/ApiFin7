using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosCodigo
{
    public decimal ProductoCodId { get; set; }

    public string ProductoCod { get; set; } = null!;

    public decimal PTipoCodigoId { get; set; }

    public decimal PEstCodigoId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PEntId { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual ExiTEstructuraCodigo PEstCodigo { get; set; } = null!;

    public virtual ExiTProducto PProducto { get; set; } = null!;

    public virtual ExiTTipoCodigo PTipoCodigo { get; set; } = null!;
}
