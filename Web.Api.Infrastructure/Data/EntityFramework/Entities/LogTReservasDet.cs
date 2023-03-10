using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTReservasDet
{
    public decimal ReservasDetId { get; set; }

    public decimal PReservasCabId { get; set; }

    public decimal PPedidoMaterialDetId { get; set; }

    public int Linea { get; set; }

    public decimal PBodegaId { get; set; }

    public byte FormaAtencionCod { get; set; }

    public decimal PDocAtencionId { get; set; }

    public double CantidadStock { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public byte EstadoProdCod { get; set; }

    public byte SituacionContCod { get; set; }

    public byte ConEstCod { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string LogOwner { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public decimal PLoteProductoId { get; set; }

    public DateTime FechaProduccion { get; set; }

    public decimal PRecCabId { get; set; }

    public byte EstadoProcesoCompra { get; set; }

    public decimal POcDetId { get; set; }

    public virtual LogTEstadoProducto EstadoProdCodNavigation { get; set; } = null!;

    public virtual ICollection<LogTPickingDet> LogTPickingDets { get; } = new List<LogTPickingDet>();

    public virtual ExiTBodega PBodega { get; set; } = null!;

    public virtual LogTPedidoMaterialDet PPedidoMaterialDet { get; set; } = null!;

    public virtual LogTReservasCab PReservasCab { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMedStock { get; set; } = null!;

    public virtual LogTSituacionContable SituacionContCodNavigation { get; set; } = null!;
}
