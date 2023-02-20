using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LogTPedidoMaterialCab
{
    public decimal PedidoMaterialId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short ProNegocioCod { get; set; }

    public decimal PBodegaId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public byte TipoCompraCod { get; set; }

    public DateTime FechaRequerida { get; set; }

    public decimal PBodDestinoId { get; set; }

    public decimal PCconsumoId { get; set; }

    public byte PedidoParcialidad { get; set; }

    public byte PedidoTipoRecepcion { get; set; }

    public string GlosaExis { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public DateTime FechaEstadoPedido { get; set; }

    public string UsuarioProceso { get; set; } = null!;

    public DateTime FechaProceso { get; set; }

    public string UsuarioAprobacion { get; set; } = null!;

    public DateTime FechaAprobacion { get; set; }

    public string UsuarioAnula { get; set; } = null!;

    public string LogOwner { get; set; } = null!;

    public string IdFuncionalidad { get; set; } = null!;

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public double ValorTotal { get; set; }

    public double TotalAfeIva { get; set; }

    public double TotalExeIva { get; set; }

    public double Iva { get; set; }

    public double TotalIva { get; set; }

    public double TotalPedidoCompra { get; set; }

    public byte AfectaConsignacion { get; set; }

    public decimal PConvenioCabId { get; set; }

    public virtual GlbTDivision DivCodigoNavigation { get; set; } = null!;

    public virtual ICollection<LogTPedidoMaterialCabCont> LogTPedidoMaterialCabConts { get; } = new List<LogTPedidoMaterialCabCont>();

    public virtual ICollection<LogTPedidoMaterialDet> LogTPedidoMaterialDets { get; } = new List<LogTPedidoMaterialDet>();

    public virtual ICollection<LogTReservasCab> LogTReservasCabs { get; } = new List<LogTReservasCab>();

    public virtual ExiTBodega PBodega { get; set; } = null!;

    public virtual GlbTEmpresa PEmp { get; set; } = null!;

    public virtual LogTTipoOperacione PTipoOpe { get; set; } = null!;
}
