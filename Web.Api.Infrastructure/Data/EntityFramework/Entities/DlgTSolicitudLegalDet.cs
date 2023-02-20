using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTSolicitudLegalDet
{
    public decimal SolicitudLegalDetId { get; set; }

    public decimal PSolicitudLegalCabId { get; set; }

    public decimal PDdoReferenciaId { get; set; }

    public byte DldTipoCodigo { get; set; }

    public decimal PProductoId { get; set; }

    public double SldCantidad { get; set; }

    public double SldMonto { get; set; }

    public decimal PMonedaId { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
