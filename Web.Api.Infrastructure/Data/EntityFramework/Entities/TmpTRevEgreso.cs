using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRevEgreso
{
    public string CabOpeOwner { get; set; } = null!;

    public decimal PCabOpeId { get; set; }

    public decimal PMovCceId { get; set; }

    public byte SisCodOri { get; set; }
}
