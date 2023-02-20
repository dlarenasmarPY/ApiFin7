using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class IntTVtaCabInterfazAux
{
    public string IntTmpOwner { get; set; } = null!;

    public decimal PDoctoVentaCabId { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public byte DvcTipoDocto { get; set; }

    public int DvcNumDocto { get; set; }

    public decimal PNegocioVtaId { get; set; }

    public string EntRutVendedor { get; set; } = null!;

    public string EntRutDigitador { get; set; } = null!;

    public DateTime FechaDocumento { get; set; }

    public short UblCodigo { get; set; }

    public string EntRut { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public int CondPagoCod { get; set; }

    public double CdpPorcRecargo { get; set; }

    public double CdpPorcDescto { get; set; }

    public byte TpdTipoParidad { get; set; }

    public double DvcValorParidad { get; set; }

    public DateTime FechaParidad { get; set; }

    public string DvcNumOrdenC { get; set; } = null!;

    public DateTime DvcFecOrdenC { get; set; }

    public DateTime DvcFecDespacho { get; set; }

    public decimal PConvenioCabId { get; set; }

    public decimal PMonedaId { get; set; }

    public double CfgPorcIva { get; set; }

    public double CfgPorcCreditoIva { get; set; }

    public short TnpCodigo { get; set; }

    public string DvcTipoFecha { get; set; } = null!;

    public short DvcTipoOrigen { get; set; }

    public short CliIndDespachoParcial { get; set; }

    public string EntDirDireccion { get; set; } = null!;

    public string EntDirDireccionSec { get; set; } = null!;

    public byte DvcUsaCantidad { get; set; }

    public int CreCodigo { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public byte ConEstCod { get; set; }

    public string IdUsuarioIngReg { get; set; } = null!;

    public string IntBitArchivo { get; set; } = null!;

    public int CabOpeLinea { get; set; }

    public decimal PVendedorId { get; set; }

    public decimal PVendedorDigitaId { get; set; }

    public decimal PEntId { get; set; }

    public decimal PEntSucId { get; set; }

    public decimal PCondPagoId { get; set; }

    public decimal PCreId { get; set; }

    public decimal PCdiId { get; set; }

    public decimal PEntDirId { get; set; }

    public decimal PEntDirDespachoId { get; set; }
}
