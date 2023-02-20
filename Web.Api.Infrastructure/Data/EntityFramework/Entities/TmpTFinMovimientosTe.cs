using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTFinMovimientosTe
{
    public string CodOwner { get; set; } = null!;

    public int CabOpeLinea { get; set; }

    public int InstCod { get; set; }

    public decimal PCtaCteBcoId { get; set; }

    public decimal PCtaId { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCreId { get; set; }

    public int CdiCodigo { get; set; }

    public int CfiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PLineaProdId { get; set; }

    public decimal PEntId { get; set; }

    public short EntSucNumero { get; set; }

    public decimal PEntIdSec { get; set; }

    public short EntSucNumeroSec { get; set; }

    public decimal PEntIdTer { get; set; }

    public short EntSucNumeroTer { get; set; }

    public DateTime MovTesFecVenc { get; set; }

    public DateTime MovTesFecProyectada { get; set; }

    public short TdoId { get; set; }

    public string MovTesNumero { get; set; } = null!;

    public short MovTesNumCuota { get; set; }

    public string MovTesGlosa { get; set; } = null!;

    public double MovTesMontoImpuDebe { get; set; }

    public double MovTesMontoImpuHaber { get; set; }

    public double MovTesMontoLocalDebe { get; set; }

    public double MovTesMontoLocalHaber { get; set; }

    public short DivCodigo { get; set; }

    public decimal PPartidaId { get; set; }

    public byte MovTesEstado { get; set; }

    public DateTime MovTesFecEstado { get; set; }

    public decimal PEntIdPago { get; set; }

    public decimal PEmpIdDestino { get; set; }

    public short UniCodigoDestino { get; set; }

    public decimal PCabOpeId { get; set; }

    public string MovTesDocRef { get; set; } = null!;
}
