using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class VtaTCotizacionCab
{
    public decimal CotizacionCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PPedidoMaterialId { get; set; }

    public byte DvcTipoDocto { get; set; }

    public int DvcNumDocto { get; set; }

    public decimal PNegocioVtaId { get; set; }

    public decimal PVendedorId { get; set; }

    public decimal PVendedorDigitaId { get; set; }

    public DateTime FechaDocumento { get; set; }

    public short UblCodigo { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public decimal PEntIdSec { get; set; }

    public decimal PEntSucIdSec { get; set; }

    public decimal PCondPagoId { get; set; }

    public double CdpPorcRecargo { get; set; }

    public double CdpPorcDescto { get; set; }

    public double DvcPorcDescto1 { get; set; }

    public double DvcPorcDescto2 { get; set; }

    public byte TpdTipoParidad { get; set; }

    public double DvcValorParidad { get; set; }

    public DateTime FechaParidad { get; set; }

    public string DvcNumOrdenC { get; set; } = null!;

    public DateTime DvcFecOrdenC { get; set; }

    public DateTime DvcFecDespacho { get; set; }

    public decimal PConvenioId { get; set; }

    public decimal PMonedaId { get; set; }

    public double CfgPorcIva { get; set; }

    public double CfgPorcCreditoIva { get; set; }

    public double CfgPorcRetencion { get; set; }

    public string DvcAtencionAcot { get; set; } = null!;

    public short DvcTipoCotizacion { get; set; }

    public short TnpCodigo { get; set; }

    public string DvcTipoFecha { get; set; } = null!;

    public short DvcTipoOrigen { get; set; }

    public short CliIndDespachoParcial { get; set; }

    public byte DvcIndPagoFlete { get; set; }

    public byte DvcIndConsolida { get; set; }

    public byte DvcUsaCantidad { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PContratoid { get; set; }

    public int DvcCantRechazo { get; set; }

    public byte ConEstCod { get; set; }

    public string CodOwner { get; set; } = null!;

    public byte DvcIndInformativa { get; set; }

    public DateTime DvcFechaVigencia { get; set; }

    public string DvcGlosaPerdida { get; set; } = null!;

    public decimal PGlbMotivoIdPerdida { get; set; }

    public string EstadoReg { get; set; } = null!;

    public DateTime FecEstadoReg { get; set; }

    public DateTime FecIngReg { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public DateTime FecUltModifReg { get; set; }

    public string IdUsuarioUltModifReg { get; set; } = null!;

    public string IdFuncionUltModifReg { get; set; } = null!;
}
