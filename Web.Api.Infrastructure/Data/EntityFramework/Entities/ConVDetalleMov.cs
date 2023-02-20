using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class ConVDetalleMov
{
    public int TipoMov { get; set; }

    public decimal PEmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short Perid { get; set; }

    public short TdoId { get; set; }

    public int CabOpeNumero { get; set; }

    public string MovGlosa { get; set; } = null!;

    public int CdiCodigo { get; set; }

    public decimal PTprId { get; set; }

    public string PryNumero { get; set; } = null!;

    public decimal PEntId { get; set; }

    public decimal PCtaId { get; set; }

    public int CtaCodigo { get; set; }

    public decimal PCreId { get; set; }

    public int CreCodigo { get; set; }

    public double MontoLocalDebe { get; set; }

    public double MontoLocalHaber { get; set; }
}
