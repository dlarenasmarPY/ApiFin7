using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class TmpTRhuContrato
{
    public string CodOwner { get; set; } = null!;

    public decimal PCtoId { get; set; }

    public decimal PFicPerId { get; set; }
}
