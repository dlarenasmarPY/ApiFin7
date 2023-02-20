using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTPedidoMaterialDet
{
    public decimal PedidoMaterialDetId { get; set; }

    public decimal PPedidoMaterialId { get; set; }

    public int Linea { get; set; }

    public decimal PServicioId { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PProductoCodId { get; set; }

    public decimal PCategoriaId { get; set; }

    public double Cantidad { get; set; }

    public double CantPendiente { get; set; }

    public double Cantidad2 { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PBodegaId { get; set; }

    public DateTime FechaRequerida { get; set; }

    public byte ConEstCod { get; set; }

    public decimal PMonedaId { get; set; }

    public double ValorUniOpeMoneda { get; set; }

    public double ValorUniOpeMonedaAlt { get; set; }

    public byte IndControlCalidad { get; set; }

    public decimal PEntId { get; set; }

    public string GlosaExis { get; set; } = null!;

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int Item { get; set; }

    public byte IndFabricacion { get; set; }

    public byte FormaAtencionCod { get; set; }

    public double CantidadStockPed { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public decimal PDoctoVentaDetId { get; set; }

    public double CantidadKit { get; set; }

    public double CantidadKitDespachada { get; set; }

    public virtual ICollection<LogTPedidoMaterialDetCont> LogTPedidoMaterialDetConts { get; } = new List<LogTPedidoMaterialDetCont>();

    public virtual ICollection<LogTPedidoMaterialDetEspTec> LogTPedidoMaterialDetEspTecs { get; } = new List<LogTPedidoMaterialDetEspTec>();

    public virtual ICollection<LogTReservasDet> LogTReservasDets { get; } = new List<LogTReservasDet>();

    public virtual ExiTProductosCategoria PCategoria { get; set; } = null!;

    public virtual LogTPedidoMaterialCab PPedidoMaterial { get; set; } = null!;

    public virtual ExiTUnidadesMedidum PUnidadMed { get; set; } = null!;
}
