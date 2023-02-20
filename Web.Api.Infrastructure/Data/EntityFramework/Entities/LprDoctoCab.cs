using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class LprDoctoCab
{
    public decimal? DoctoCabId { get; set; }

    public int? SistemaBase { get; set; }

    public int? SisCodOri { get; set; }

    public decimal? PEmpId { get; set; }

    public int? DivCodigo { get; set; }

    public int? UniCodigo { get; set; }

    public int? TdoId { get; set; }

    public int? IndDlgMe { get; set; }

    public int? UblCodigo { get; set; }

    public int? FolioDocto { get; set; }

    public decimal? PNegocioVtaId { get; set; }

    public decimal? PTipoOpeId { get; set; }

    public decimal? PVendedorId { get; set; }

    public string? FechaDocto { get; set; }

    public string? FechaVecto { get; set; }

    public decimal? PEntId { get; set; }

    public decimal? PEntSucId { get; set; }

    public decimal? PEntIdSec { get; set; }

    public decimal? PEntSucIdSec { get; set; }

    public decimal? PCondPagoId { get; set; }

    public double? CabPorcDescto1 { get; set; }

    public double? CabPorcDescto2 { get; set; }

    public double? CabPorcDesctoCdp { get; set; }

    public double? CabPorcRecargo { get; set; }

    public string? NumeroOrdenC { get; set; }

    public string? FechaOrdenC { get; set; }

    public string? TipoReferencia { get; set; }

    public int? NumeroReferencia { get; set; }

    public decimal? PDocReferenciaId { get; set; }

    public decimal? PDoctoVentaCabId { get; set; }

    public decimal? PDoctoLegalCabOid { get; set; }

    public string? TipoDocumento { get; set; }

    public int? NumeroDocumento { get; set; }

    public int? IndDocumento { get; set; }

    public int? IndContabiliza { get; set; }

    public int? IndAnticipo { get; set; }

    public decimal? PCreId { get; set; }

    public decimal? PCdiId { get; set; }

    public decimal? PTprId { get; set; }

    public string? PryNumero { get; set; }

    public double? MtoAfecto { get; set; }

    public double? MtoAfectoLocal { get; set; }

    public double? MtoExento { get; set; }

    public double? MtoExentoLocal { get; set; }

    public double? MtoDescuento { get; set; }

    public double? MtoDescuentoLocal { get; set; }

    public double? MtoRecargo { get; set; }

    public double? MtoRecargoLocal { get; set; }

    public double? MtoIva { get; set; }

    public double? MtoIvaLocal { get; set; }

    public double? MtoImpuesto { get; set; }

    public double? MtoImpuestoLocal { get; set; }

    public double? MtoRetencion { get; set; }

    public double? MtoRetencionLocal { get; set; }

    public double? MtoCreditoIva { get; set; }

    public double? MtoCreditoIvaLocal { get; set; }

    public double MtoIvaRetenido { get; set; }

    public double MtoIvaRetenidoLocal { get; set; }

    public double? MtoTotal { get; set; }

    public double? MtoTotalLocal { get; set; }

    public decimal? PMonedaNegocioVtaId { get; set; }

    public double? CfgPorcIva { get; set; }

    public double? CfgPorcCreditoIva { get; set; }

    public double? CfgPorcRetencion { get; set; }

    public double DlcPorcIvaRetenido { get; set; }

    public decimal? PIdiomaEspId { get; set; }

    public int? UsaCantidad { get; set; }

    public decimal? PUnidadEmisoraDetId { get; set; }

    public decimal? PEmbarqueCabId { get; set; }

    public string? UsuarioProceso { get; set; }

    public int? TipoParidad { get; set; }

    public string? FechaParidad { get; set; }

    public double? ValorParidad { get; set; }

    public int CfgDlgUsaParidadExacta { get; set; }

    public int NumLineaDocto { get; set; }

    public int CfgDlgTotalHoja { get; set; }

    public int CfgDlgLargoLinea { get; set; }

    public string CfgDlgSeparador { get; set; } = null!;

    public int CfgDlgImprimeComponente { get; set; }

    public int? EjeAno { get; set; }

    public int NroDec { get; set; }

    public int PMonedaLocalId { get; set; }

    public int NroDecLocal { get; set; }

    public int PMonedaConvId { get; set; }

    public int NroDecConv { get; set; }
}
