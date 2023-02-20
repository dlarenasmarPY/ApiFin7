using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRelEntModalidad
{
    public decimal PEntCcoId { get; set; }

    public byte ModCcoCod { get; set; }

    public string RelEntMod { get; set; } = null!;
}
