using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTDlgImprimeDocto
{
    public string CodOwner { get; set; } = null!;

    public decimal PDoctoLegalCabId { get; set; }

    public byte SisCodOri { get; set; }

    public short PerId { get; set; }

    public short TdoId { get; set; }

    public byte IndDlgMe { get; set; }

    public int DlcFolioDocto { get; set; }

    public decimal PVendedorId { get; set; }

    public string UserVenResp { get; set; } = null!;

    public DateTime DlcFecDocto { get; set; }

    public DateTime DlcFecVecto { get; set; }

    public decimal PEntId { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public string EntSucDescripcion { get; set; } = null!;

    public string EntDirDireccion { get; set; } = null!;

    public string CiuNombre { get; set; } = null!;

    public string CmuNombre { get; set; } = null!;

    public string RegNombre { get; set; } = null!;

    public decimal PEntIdSec { get; set; }

    public string EntRutSec { get; set; } = null!;

    public string EntRazonSocialSec { get; set; } = null!;

    public short EntSucNumeroSec { get; set; }

    public string EntSucDescripcionSec { get; set; } = null!;

    public string EntDirDireccionSec { get; set; } = null!;

    public string CiuNombreSec { get; set; } = null!;

    public string CmuNombreSec { get; set; } = null!;

    public string RegNombreSec { get; set; } = null!;

    public decimal PCondPagoId { get; set; }

    public int CondPagoCod { get; set; }

    public string CondPagoDes { get; set; } = null!;

    public double DlcPorcDesctoCdp { get; set; }

    public double DlcPorcRecargo { get; set; }

    public double DlcPorcDescto1 { get; set; }

    public double DlcPorcDescto2 { get; set; }

    public string DvcNumOrdenC { get; set; } = null!;

    public DateTime DvcFecOrdenC { get; set; }

    public string DvcTipoRefer { get; set; } = null!;

    public int DvcNumRefer { get; set; }

    public byte DvcTipoDocto { get; set; }

    public int DvcNumDocto { get; set; }

    public byte DlcIndDocumento { get; set; }

    public double DlcMtoAfecto { get; set; }

    public double DlcMtoExento { get; set; }

    public double DlcMtoDescto { get; set; }

    public double DlcMtoRecargo { get; set; }

    public double DlcMtoIva { get; set; }

    public double DlcMtoImptoEsp { get; set; }

    public double DlcMtoRetencion { get; set; }

    public double DlcMtoCreditoIva { get; set; }

    public double DlcMtoTotal { get; set; }

    public string MontoEscrito { get; set; } = null!;

    public decimal PMonedaId { get; set; }

    public string MonGlosa { get; set; } = null!;

    public double CfgPorcIva { get; set; }

    public double CfgPorcCreditoIva { get; set; }

    public double CfgPorcRetencion { get; set; }

    public decimal PUnidadEmisoraDetId { get; set; }

    public decimal PDoctoLegalDetId { get; set; }

    public short DldItem { get; set; }

    public decimal PProductoKitId { get; set; }

    public string ProductoKitCod { get; set; } = null!;

    public string ProductoKitDes { get; set; } = null!;

    public byte DldTipoCodigo { get; set; }

    public decimal PProductoId { get; set; }

    public string ProductoCod { get; set; } = null!;

    public string ProductoDes { get; set; } = null!;

    public decimal PUnidadMedKitId { get; set; }

    public string UnidadMedKitCod { get; set; } = null!;

    public decimal PUnidadMedId { get; set; }

    public string UnidadMedCod { get; set; } = null!;

    public decimal PUnidadMed2Id { get; set; }

    public string UnidadMedida2 { get; set; } = null!;

    public double DldCantDoctoFacKit { get; set; }

    public double DldCantDoctoFac { get; set; }

    public double Cantidad2 { get; set; }

    public double DldPrecioUnitarioKit { get; set; }

    public double DldPrecioUnitario { get; set; }

    public double DldPorcDescto1 { get; set; }

    public double DldPorcDescto2 { get; set; }

    public double DldMtoAfecto { get; set; }

    public double DldMtoExento { get; set; }

    public double DldMtoDescto { get; set; }

    public double DldMtoRecargo { get; set; }

    public double DldMtoImptoEsp { get; set; }

    public double DldMtoRetencion { get; set; }

    public double DldMtoTotal { get; set; }

    public short DlgLinea { get; set; }

    public string DlgGlosaItem { get; set; } = null!;
}
