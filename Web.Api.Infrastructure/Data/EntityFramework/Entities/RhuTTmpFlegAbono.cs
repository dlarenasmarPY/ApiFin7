using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class RhuTTmpFlegAbono
{
    public string CodOwner { get; set; } = null!;

    public decimal PCtoId { get; set; }

    public DateTime FlegMabPerInicio { get; set; }

    public DateTime FlegMabPerTermino { get; set; }

    public double FlegMabDiasDer { get; set; }

    public double FlegMabDiasPro { get; set; }

    public double FlegMabDiasAdi { get; set; }

    public double FlegMabDiasSal { get; set; }
}
