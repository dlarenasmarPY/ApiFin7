using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ExiTUnidadesMedidum
{
    public decimal UnidadMedId { get; set; }

    public string UnidadMedCod { get; set; } = null!;

    public string UnidadMedDes { get; set; } = null!;

    public DateTime FechaVigencia { get; set; }

    public byte NroDec { get; set; }

    public virtual ICollection<AdqTCotizacionDet> AdqTCotizacionDetPUnidadMedCompras { get; } = new List<AdqTCotizacionDet>();

    public virtual ICollection<AdqTCotizacionDet> AdqTCotizacionDetPUnidadMedStocks { get; } = new List<AdqTCotizacionDet>();

    public virtual ICollection<AdqTCotizacionDetResp> AdqTCotizacionDetResps { get; } = new List<AdqTCotizacionDetResp>();

    public virtual ICollection<AdqTListaPrecioCompraDet> AdqTListaPrecioCompraDetPUnidadMedCompras { get; } = new List<AdqTListaPrecioCompraDet>();

    public virtual ICollection<AdqTListaPrecioCompraDet> AdqTListaPrecioCompraDetPUnidadMedStocks { get; } = new List<AdqTListaPrecioCompraDet>();

    public virtual ICollection<AdqTOcDet> AdqTOcDetPUnidadMedCompras { get; } = new List<AdqTOcDet>();

    public virtual ICollection<AdqTOcDet> AdqTOcDetPUnidadMedStocks { get; } = new List<AdqTOcDet>();

    public virtual ICollection<AdqTProcesoCompraDet> AdqTProcesoCompraDetPUnidadMedOrigens { get; } = new List<AdqTProcesoCompraDet>();

    public virtual ICollection<AdqTProcesoCompraDet> AdqTProcesoCompraDetPUnidadMedStocks { get; } = new List<AdqTProcesoCompraDet>();

    public virtual ICollection<ExiTProductosUnidadesMedidum> ExiTProductosUnidadesMedida { get; } = new List<ExiTProductosUnidadesMedidum>();

    public virtual ICollection<ExiTServicio> ExiTServicios { get; } = new List<ExiTServicio>();

    public virtual ICollection<LogTOperacionesLogtDet> LogTOperacionesLogtDetPUnidadMedOrigens { get; } = new List<LogTOperacionesLogtDet>();

    public virtual ICollection<LogTOperacionesLogtDet> LogTOperacionesLogtDetPUnidadMedStocks { get; } = new List<LogTOperacionesLogtDet>();

    public virtual ICollection<LogTPedidoMaterialDet> LogTPedidoMaterialDets { get; } = new List<LogTPedidoMaterialDet>();

    public virtual ICollection<LogTReservasDet> LogTReservasDets { get; } = new List<LogTReservasDet>();
}
