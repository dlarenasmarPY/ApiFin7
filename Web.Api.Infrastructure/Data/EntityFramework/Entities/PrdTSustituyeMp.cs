using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTSustituyeMp
{
    public string CodOwner { get; set; } = null!;

    public byte Estado { get; set; }

    public string ProductoCod { get; set; } = null!;

    public short NumFormula { get; set; }

    public decimal PFormulaId { get; set; }
}
