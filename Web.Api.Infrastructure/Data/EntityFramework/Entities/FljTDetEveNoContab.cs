using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class FljTDetEveNoContab
{
    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public decimal PMonedaId { get; set; }

    public decimal PCtaId { get; set; }

    public int CreCodigo { get; set; }

    public string MovRut { get; set; } = null!;

    public short MovSucNumero { get; set; }

    public short MovDocTipo { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public short MovCceNumCuota { get; set; }

    public DateTime TesDocFecha { get; set; }

    public decimal TesDocMontoImpuDebe { get; set; }

    public decimal TesDocMontoImpuHaber { get; set; }

    public decimal TesDocMontoLocalDebe { get; set; }

    public decimal TesDocMontoLocalHaber { get; set; }
}
