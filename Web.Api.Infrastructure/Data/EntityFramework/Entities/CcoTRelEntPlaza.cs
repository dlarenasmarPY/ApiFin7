using System;
using System.Collections.Generic;

namespace Web.Api.Infrastructure.Data.EntityFramework.Entities;

public partial class CcoTRelEntPlaza
{
    public decimal PEntCcoId { get; set; }

    public int CmuCodigo { get; set; }

    public int PlaCod { get; set; }

    public string RelEntCmu { get; set; } = null!;

    public string RelEntPla { get; set; } = null!;
}
