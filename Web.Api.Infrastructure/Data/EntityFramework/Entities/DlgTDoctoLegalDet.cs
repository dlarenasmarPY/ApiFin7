using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalDet
{
    public decimal DoctoLegalDetId { get; set; }

    public decimal PDoctoLegalCabId { get; set; }

    public short DldItem { get; set; }

    public decimal PProductoKitId { get; set; }

    public byte DldTipoCodigo { get; set; }

    public decimal PProductoId { get; set; }

    public decimal PUnidadMedId { get; set; }

    public decimal PUnidadMedStockId { get; set; }

    public decimal PUnidadMedDespachoId { get; set; }

    public decimal PUnidadMed2Id { get; set; }

    public double DldCantComponente { get; set; }

    public double DldCantDoctoFac { get; set; }

    public double DldCantidadStock { get; set; }

    public double DldCantidadDespacho { get; set; }

    public double DldCantidad2 { get; set; }

    public double DldPrecioUnitarioOriginal { get; set; }

    public double DldPrecioUnitarioVenta { get; set; }

    public double DldPrecioUnitario { get; set; }

    public double DldPrecioUnitarioLocal { get; set; }

    public double DldPrecioUnitarioConv { get; set; }

    public byte UnidadMedMultDivide { get; set; }

    public double UnidadMedConversion { get; set; }

    public decimal PListaPreCabId { get; set; }

    public double DldPorcDescto1 { get; set; }

    public double DldPorcDescto2 { get; set; }

    public decimal PDetReferenciaId { get; set; }

    public decimal PDdoReferenciaId { get; set; }

    public decimal PDoctoVentaDetId { get; set; }

    public decimal PRebateId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte DldIndAfectoExento { get; set; }

    public byte DldIndRetencion { get; set; }

    public byte DldIndImptoEsp { get; set; }

    public byte DldIndImpresion { get; set; }

    public double DldMtoNeto { get; set; }

    public double DldMtoNetoLocal { get; set; }

    public double DldMtoNetoConv { get; set; }

    public double DldMtoAfecto { get; set; }

    public double DldMtoAfectoLocal { get; set; }

    public double DldMtoAfectoConv { get; set; }

    public double DldMtoExento { get; set; }

    public double DldMtoExentoLocal { get; set; }

    public double DldMtoExentoConv { get; set; }

    public double DldMtoDescto { get; set; }

    public double DldMtoDesctoLocal { get; set; }

    public double DldMtoDesctoConv { get; set; }

    public double DldMtoRecargo { get; set; }

    public double DldMtoRecargoLocal { get; set; }

    public double DldMtoRecargoConv { get; set; }

    public double DldMtoImptoEsp { get; set; }

    public double DldMtoImptoEspLocal { get; set; }

    public double DldMtoImptoEspConv { get; set; }

    public double DldMtoRetencion { get; set; }

    public double DldMtoRetencionLocal { get; set; }

    public double DldMtoRetencionConv { get; set; }

    public double DldMtoTotal { get; set; }

    public double DldMtoTotalLocal { get; set; }

    public double DldMtoTotalConv { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public byte SerUsaVentaTercero { get; set; }

    public double DldValorParidadLocal { get; set; }

    public decimal PConvenioDetId { get; set; }

    public decimal PProductoCodId { get; set; }

    public byte TseCodigo { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public decimal PDoctoVentaCabProId { get; set; }

    public double DldMtoIva { get; set; }

    public double DldMtoIvaLocal { get; set; }

    public double DldMtoIvaConv { get; set; }

    public double DldPorcDescto3 { get; set; }

    public double DldPorcDescto4 { get; set; }

    public double DldComisionUnitaria { get; set; }

    public double DldComisionUnitariaLocal { get; set; }

    public double DldComisionUnitariaConv { get; set; }

    public double DldPorcComision { get; set; }

    public double DldMtoComision { get; set; }

    public double DldMtoComisionLocal { get; set; }

    public double DldMtoComisionConv { get; set; }

    public decimal PGenericoId { get; set; }

    public double DvdKiloNeto { get; set; }

    public double DvdKiloBruto { get; set; }

    public decimal PDetReferenciaKitId { get; set; }

    public byte IndKitPre { get; set; }

    public decimal PCtaProvisionIngId { get; set; }

    public decimal PDetReferenciaExtId { get; set; }
}
