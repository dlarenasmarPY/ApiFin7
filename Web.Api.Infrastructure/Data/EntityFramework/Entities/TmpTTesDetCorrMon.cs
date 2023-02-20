using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTTesDetCorrMon
{
    public string CodOwner { get; set; } = null!;

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public int CtaCodigo { get; set; }

    public decimal PMonedaId { get; set; }

    public int CreCodigo { get; set; }

    public int CdiCodigo { get; set; }

    public string EntRut { get; set; } = null!;

    public short EntSucNumero { get; set; }

    public string EntRutSec { get; set; } = null!;

    public short EntSucNumeroSec { get; set; }

    public short TdoId { get; set; }

    public string DocCceNumero { get; set; } = null!;

    public short MovCceNumCuota { get; set; }

    public string MovCceGlosa { get; set; } = null!;

    public double MovCceMontoImpuDebe { get; set; }

    public double MovCceMontoImpuHaber { get; set; }

    public double MovCceMontoLocalDebe { get; set; }

    public double MovCceMontoLocalHaber { get; set; }

    public double MovCceMontoConvDebe { get; set; }

    public double MovCceMontoConvHaber { get; set; }
}
