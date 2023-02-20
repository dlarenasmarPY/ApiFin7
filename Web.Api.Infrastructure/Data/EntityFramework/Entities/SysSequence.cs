using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class SysSequence
{
    public string Name { get; set; } = null!;

    public decimal Value { get; set; }
}
