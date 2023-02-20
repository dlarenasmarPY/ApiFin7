using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTFinMovimiento
{
    public string CodOwner { get; set; } = null!;

    public int CabOpeLinea { get; set; }

    public short DivCodigo { get; set; }

    public int CreCodigo { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public short MovCceNumCuota { get; set; }

    public string TdoNomCorto { get; set; } = null!;

    public DateTime MovCceFecVenc { get; set; }

    public string EntRazonSocial { get; set; } = null!;

    public string CodCtaCteBco { get; set; } = null!;

    public int CtaCodigo { get; set; }

    public string MonSimbolo { get; set; } = null!;

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public decimal PMovCceId { get; set; }

    public byte TauId { get; set; }
}
