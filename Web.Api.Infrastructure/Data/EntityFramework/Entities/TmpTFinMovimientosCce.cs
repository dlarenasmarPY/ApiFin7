using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTFinMovimientosCce
{
    public string CodOwner { get; set; } = null!;

    public int CabOpeLinea { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public decimal PEntIdTer { get; set; }

    public short EntSucNumeroTer { get; set; }

    public DateTime MovCceFecVenc { get; set; }

    public DateTime DocCceFecProyectada { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public short MovCceNumCuota { get; set; }

    public int InstCod { get; set; }

    public int PlaCod { get; set; }

    public string MovCceGlosa { get; set; } = null!;

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public short DivCodigo { get; set; }

    public decimal PPartidaId { get; set; }

    public string DocCceCtaCteBco { get; set; } = null!;

    public short DocCceTotCuota { get; set; }

    public DateTime DocCceFecLib { get; set; }

    public byte DocCceEstado { get; set; }

    public byte DocCceSco { get; set; }

    public string DocCceUserCobResp { get; set; } = null!;

    public string DocCceUserVenResp { get; set; } = null!;

    public int DocCcePorEncaje { get; set; }

    public byte DocCceIndSelec { get; set; }

    public int CfiCodigo { get; set; }

    public DateTime MovCceDigFec { get; set; }

    public byte MovCceEstado { get; set; }

    public DateTime MovCceFecEstado { get; set; }

    public decimal PEntIdPago { get; set; }

    public decimal PMovTesId { get; set; }

    public decimal PFormaPagoId { get; set; }

    public DateTime MovCceFecPagoPropuesta { get; set; }

    public short UniCodigoEmi { get; set; }

    public decimal PEmpIdDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public string MovCceDocRef { get; set; } = null!;
}
