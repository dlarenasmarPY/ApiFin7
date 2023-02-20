using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTFinOperacione
{
    public string CodOwner { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public decimal EmpId { get; set; }

    public short DivCodigo { get; set; }

    public short UniCodigo { get; set; }

    public short PerId { get; set; }

    public int CabOpeLineaActual { get; set; }

    public string CabOpeGlosa { get; set; } = null!;

    public string OpeGlosa { get; set; } = null!;

    public int CabOpeNumero { get; set; }

    public string TcoGlosaCorta { get; set; } = null!;

    public int ComNumero { get; set; }

    public DateTime CabOpeFecha { get; set; }

    public byte ConEstCod { get; set; }

    public string CabOpeDigUsuario { get; set; } = null!;

    public DateTime CabOpeDigFec { get; set; }

    public string CabOpeAprUsuario { get; set; } = null!;

    public DateTime CabOpeAprFec { get; set; }

    public string CabOpeActUsuario { get; set; } = null!;

    public DateTime CabOpeActFec { get; set; }

    public DateTime CabOpeFecReversa { get; set; }

    public double MovConMontoLocalDebe { get; set; }

    public double MovConMontoLocalHaber { get; set; }
}
