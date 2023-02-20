using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class WsCcoTmpCarta
{
    public string CodOwner { get; set; } = null!;

    public decimal PEntId { get; set; }

    public string EntRut { get; set; } = null!;

    public string EntRazonSocial { get; set; } = null!;
}
