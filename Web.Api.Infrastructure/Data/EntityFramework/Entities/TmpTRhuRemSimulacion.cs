using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuRemSimulacion
{
    public string CodOwner { get; set; } = null!;

    public decimal PFicPerId { get; set; }

    public decimal LqTperId { get; set; }

    public string PerGlosa { get; set; } = null!;

    public decimal LqTperIdDev { get; set; }

    public string PerGlosaDev { get; set; } = null!;

    public decimal PConcRemId { get; set; }

    public string CnRcodigo { get; set; } = null!;

    public string CnRdescripcion { get; set; } = null!;

    public string CnRtipoFormula { get; set; } = null!;

    public double LqDvalor { get; set; }

    public string LqDvalBaseAlf { get; set; } = null!;

    public DateTime LqDvalBaseFec { get; set; }

    public double LqDvalBaseNum { get; set; }

    public decimal LqDorigenMov { get; set; }

    public decimal LqDrefOrigenId { get; set; }
}
