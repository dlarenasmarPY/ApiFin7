using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTLotesProducto
{
    public decimal LoteProductoId { get; set; }

    public decimal PProductoId { get; set; }

    public string LoteProductoCod { get; set; } = null!;

    public byte SituacionContCod { get; set; }

    public byte EstadoProdCod { get; set; }

    public DateTime LoteFecCreacion { get; set; }

    public DateTime LoteFecExpiracion { get; set; }

    public string Referencia1Logt { get; set; } = null!;

    public string Referencia2Logt { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public virtual LogTEstadoProducto EstadoProdCodNavigation { get; set; } = null!;

    public virtual ExiTProducto PProducto { get; set; } = null!;

    public virtual LogTSituacionContable SituacionContCodNavigation { get; set; } = null!;
}
