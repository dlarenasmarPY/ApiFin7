using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTProductosCodigosResp29032017
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
}
