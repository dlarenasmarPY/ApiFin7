using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class PrdTTmpCorreccionPatron
{
    public string CodOwner { get; set; } = null!;

    public decimal PFormulaId { get; set; }

    public byte Selector { get; set; }
}
