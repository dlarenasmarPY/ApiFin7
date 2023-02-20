using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class DlgTDoctoLegalCab
{
    public decimal DoctoLegalCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte SistemaBase { get; set; }

    public byte SisCodOri { get; set; }

    public short PerId { get; set; }

    public short TdoId { get; set; }

    public short UblCodigo { get; set; }

    public byte IndDlgMe { get; set; }

    public int DlcFolioDocto { get; set; }

    public decimal PNegocioVtaId { get; set; }

    public decimal PTipoOpeId { get; set; }

    public decimal PVendedorId { get; set; }

    public DateTime DlcFecDocto { get; set; }

    public DateTime DlcFecVecto { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public decimal PEntIdSec { get; set; }

    public decimal PEntSucIdSec { get; set; }

    public decimal PCondPagoId { get; set; }

    public double DlcPorcDesctoCdp { get; set; }

    public double DlcPorcRecargo { get; set; }

    public double DlcPorcDescto1 { get; set; }

    public double DlcPorcDescto2 { get; set; }

    public string DvcNumOrdenC { get; set; } = null!;

    public DateTime DvcFecOrdenC { get; set; }

    public string DvcTipoRefer { get; set; } = null!;

    public int DvcNumRefer { get; set; }

    public decimal PDocReferenciaId { get; set; }

    public decimal PDoctoVentaCabId { get; set; }

    public byte DvcTipoDocto { get; set; }

    public int DvcNumDocto { get; set; }

    public byte DvcUsaCantidad { get; set; }

    public byte DlcIndDocumento { get; set; }

    public byte DlcIndContabiliza { get; set; }

    public byte DlcIndAnticipo { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte DlcNumHoja { get; set; }

    public double DlcMtoAfecto { get; set; }

    public double DlcMtoAfectoLocal { get; set; }

    public double DlcMtoAfectoConv { get; set; }

    public double DlcMtoExento { get; set; }

    public double DlcMtoExentoLocal { get; set; }

    public double DlcMtoExentoConv { get; set; }

    public double DlcMtoDescto { get; set; }

    public double DlcMtoDesctoLocal { get; set; }

    public double DlcMtoDesctoConv { get; set; }

    public double DlcMtoRecargo { get; set; }

    public double DlcMtoRecargoLocal { get; set; }

    public double DlcMtoRecargoConv { get; set; }

    public double DlcMtoIva { get; set; }

    public double DlcMtoIvaLocal { get; set; }

    public double DlcMtoIvaConv { get; set; }

    public double DlcMtoImptoEsp { get; set; }

    public double DlcMtoImptoEspLocal { get; set; }

    public double DlcMtoImptoEspConv { get; set; }

    public double DlcMtoRetencion { get; set; }

    public double DlcMtoRetencionLocal { get; set; }

    public double DlcMtoRetencionConv { get; set; }

    public double DlcMtoCreditoIva { get; set; }

    public double DlcMtoCreditoIvaLocal { get; set; }

    public double DlcMtoCreditoIvaConv { get; set; }

    public double DlcMtoIvaRetenido { get; set; }

    public double DlcMtoIvaRetenidoLocal { get; set; }

    public double DlcMtoIvaRetenidoConv { get; set; }

    public double DlcMtoTotal { get; set; }

    public double DlcMtoTotalLocal { get; set; }

    public double DlcMtoTotalConv { get; set; }

    public double DlcMtoAfectoAnt { get; set; }

    public double DlcMtoAfectoAntLocal { get; set; }

    public double DlcMtoExentoAnt { get; set; }

    public double DlcMtoExentoAntLocal { get; set; }

    public decimal PMonedaNegocioVtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public byte DlcTipoParidad { get; set; }

    public DateTime DlcFecParidad { get; set; }

    public double DlcValorParidad { get; set; }

    public double DlcValorParidadLocal { get; set; }

    public double DlcValorParidadConv { get; set; }

    public double CfgPorcIva { get; set; }

    public double CfgPorcCreditoIva { get; set; }

    public double CfgPorcRetencion { get; set; }

    public double DlcPorcIvaRetenido { get; set; }

    public byte CliNoImprime { get; set; }

    public decimal PIdiomaEspId { get; set; }

    public byte DlcEstado { get; set; }

    public byte DlcEstadoDte { get; set; }

    public decimal PUnidadEmisoraDetId { get; set; }

    public decimal PFolioElectronicoId { get; set; }

    public decimal PCabOpeId { get; set; }

    public decimal PCabOpeIdReversa { get; set; }

    public decimal PTipoOpeIdCompra { get; set; }

    public decimal PCabLlgId { get; set; }

    public decimal LlgIdReversa { get; set; }

    public decimal PLibId { get; set; }

    public decimal PEmbarqueCabId { get; set; }

    public string CodOwner { get; set; } = null!;

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;

    public int ComNumero { get; set; }

    public double DlcMtoFlete { get; set; }

    public double DlcMtoFleteLocal { get; set; }

    public double DlcMtoFleteConv { get; set; }

    public double DlcMtoSeguro { get; set; }

    public double DlcMtoSeguroLocal { get; set; }

    public double DlcMtoSeguroConv { get; set; }

    public double DlcMtoOtroGasto { get; set; }

    public double DlcMtoOtroGastoLocal { get; set; }

    public double DlcMtoOtroGastoConv { get; set; }

    public byte DlcTipoDato { get; set; }

    public short TnpCodigo { get; set; }

    public decimal PConvenioCabId { get; set; }

    public decimal PEntDirId { get; set; }

    public decimal PEntDirDespachoId { get; set; }

    public byte DlcTipoDespacho { get; set; }

    public double DlcPorcDescto3 { get; set; }

    public double DlcPorcDescto4 { get; set; }

    public double DlcMtoComision { get; set; }

    public double DlcMtoComisionLocal { get; set; }

    public double DlcMtoComisionConv { get; set; }

    public decimal PClausulaVenta { get; set; }

    public string DvcObsDt { get; set; } = null!;

    public string DvcObsDespacho { get; set; } = null!;

    public byte DlcIndMonto { get; set; }

    public decimal PCtaId { get; set; }

    public byte DlcTipoTraslado { get; set; }

    public short TfgCodigo { get; set; }

    public byte TsfCodigo { get; set; }

    public byte TsbCodigo { get; set; }

    public short DlcCodRetenido { get; set; }

    public decimal PCabReferenciaExtId { get; set; }

    public byte CfgDlgTipoEmision { get; set; }

    public byte CfgDlgIndAmbiente { get; set; }

    public string DlcFecAutoriza { get; set; } = null!;

    public string DlcNroAutoriza { get; set; } = null!;

    public int DlcSecuencial { get; set; }

    public byte TedCodigo { get; set; }

    public int DlcEstablecimiento { get; set; }

    public int DlcPtoEmision { get; set; }
}
